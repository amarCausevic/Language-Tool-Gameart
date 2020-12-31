using JsonDiffPatchDotNet;
using LanguageToolAmar.LanguagePropertirs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageToolAmar
{
    public partial class Form1 : Form
    {
        private static HttpClient Client = new HttpClient();
        private OpenFileDialog OpenFileDialog;
        private List<LanguageProperties> ServerListGrid, LocalListGrid;
        private JObject ServerFile, LocalFile;
        private JObject DiffResult;
        private bool IsCommonLanguagePack;
        private JsonDiffPatch JsonDiffPatch;

        public Form1()
        {
            InitializeComponent();
            InitDataGridView();
            IntiComboBox();
            searchButton.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        private async Task GetAysncApi(string URL)
        {
            JObject data = null;
            try
            {
                HttpResponseMessage response = await Client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var responseResultJson = await response.Content.ReadAsStringAsync();
                    data = JObject.Parse(responseResultJson);
                    serverFileViewGrid.DataSource = CreateListFromResult(data);
                    ServerListGrid = CreateListFromResult(data);
                    ServerFile = data;
                }
                else
                {
                    MessageBox.Show("Failed to retrive any data from server ", "Retrive data from server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getURLBtn_Click(object sender, EventArgs e)
        {
            serverFileViewGrid.Refresh();
            GetAysncApi(URLGenrator());
        }

        private List<LanguageProperties> CreateListFromResult(JObject customObject)
        {
            List<LanguageProperties> newList = new List<LanguageProperties>();
            if (customObject != null)
            {
                foreach (JProperty item in customObject.Properties())
                {
                    newList.Add(new LanguageProperties(item.Name, item.Value.ToString()));
                }
                return newList;
            }
            else
            {
                MessageBox.Show("Object was empty please retry again");
            }

            return newList;
        }

        private void InitDataGridView()
        {
            serverFileViewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            serverFileViewGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            serverFileViewGrid.AllowUserToOrderColumns = true;
            serverFileViewGrid.AllowUserToResizeColumns = true;
            localFileViewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            localFileViewGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            localFileViewGrid.AllowUserToOrderColumns = true;
            localFileViewGrid.AllowUserToResizeColumns = true;
        }

        private void browseForLocalFile_Click(object sender, EventArgs e)
        {
            // TO-DO optimize
            OpenFileDialog = new OpenFileDialog();
            //OpenFileDialog.ShowDialog();
            string uriPath = "";
            if (OpenFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                uriPath = OpenFileDialog.FileName;
            }
            else
            {
                uriPath = "";
            }
            if (!string.IsNullOrEmpty(uriPath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(uriPath))
                    {
                        var json = reader.ReadToEnd();
                        var data = JObject.Parse(json);
                        localFileViewGrid.DataSource = CreateListFromResult(data);
                        LocalListGrid = CreateListFromResult(data);
                        LocalFile = data;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ServerListGrid != null)
            {
                bool resultNotfoundServerFile = false;
                bool resultFoundServerFile = false;
                serverFileViewGrid.ClearSelection();
                foreach (DataGridViewRow row1 in serverFileViewGrid.Rows)
                {
                    if (row1.Cells[0].Value.ToString().Contains(searchParamter.Text))
                    {
                        serverFileViewGrid.CurrentCell = serverFileViewGrid.Rows[row1.Index].Cells[0];
                        row1.Selected = true;
                        resultFoundServerFile = true;
                    }
                    else
                    {
                        resultNotfoundServerFile = true;
                    }
                }
                if (resultNotfoundServerFile == true && resultFoundServerFile == false)
                    MessageBox.Show("Cannot find " + searchParamter.Text + " in SERVER file. Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (LocalListGrid != null)
            {
                bool resultNotfoundLocalFile = false;
                bool resultFoundServerFile = false;
                localFileViewGrid.ClearSelection();
                foreach (DataGridViewRow row2 in localFileViewGrid.Rows)
                {
                    if (row2.Cells[0].Value.ToString().Contains(searchParamter.Text))
                    {
                        localFileViewGrid.CurrentCell = localFileViewGrid.Rows[row2.Index].Cells[0];
                        row2.Selected = true;
                        resultFoundServerFile = true;
                    }
                    else
                    {
                        resultNotfoundLocalFile = true;
                    }
                }
                if (resultNotfoundLocalFile == true && resultFoundServerFile == false)
                    MessageBox.Show("Cannot find " + searchParamter.Text + " in LOCAL file. Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ServerListGrid == null && LocalListGrid == null)
            {
                MessageBox.Show("At least one grid must be filled to trigger search", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IntiComboBox()
        {
            langSelector.DataSource = LanguagePack.LanguagePackList();
            gameSelector.DataSource = LanguageGames.LanguageGamesPack();
            langSelector.DisplayMember = "DisplayName";
            langSelector.ValueMember = "ID";
            gameSelector.DisplayMember = "DisplayName";
            gameSelector.ValueMember = "ID";
        }

        private void commonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (commonCheckBox.Checked)
            {
                gameSelector.Enabled = false;
                IsCommonLanguagePack = true;
            }
            else
            {
                gameSelector.Enabled = true;
                IsCommonLanguagePack = false;
            }
        }

        public string URLGenrator()
        {
            string URL = "";
            string gamePartURL = "-strings-";
            string commonPartURL = "-strings";
            var selectedLanguage = langSelector.SelectedItem as LanguagePack;
            var selectedGame = gameSelector.SelectedItem as LanguageGames;
            if (!IsCommonLanguagePack)
            {
                switch (selectedLanguage.ID)
                {
                    case "en":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "de":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "es":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "fr":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "hr":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "it":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "jp":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "kr":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "pt":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "ro":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "ru":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "th":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "zh":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    case "id":
                        return GameURL(selectedLanguage.ID, selectedGame.LinkPartOne, gamePartURL);

                    default:
                        MessageBox.Show("Cannot generate GAME URL");
                        break;
                }
            }
            else
            {
                switch (selectedLanguage.ID)
                {
                    case "en":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "de":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "es":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "fr":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "hr":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "it":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "jp":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "kr":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "pt":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "ro":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "ru":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "th":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "zh":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    case "id":
                        return CommonURL(selectedLanguage.ID, commonPartURL);

                    default:
                        MessageBox.Show("Cannot generate COMMON URL");
                        break;
                }
            }
            return URL;
        }

        private string GameURL(string langID, string langGame, string strings)
        {
            return string.Format(@"https://hg4dev.gahypergaming.com/gameart/games/translations/{0}/{1}/{2}{3}{4}.json", langGame, langID, langID, strings, langGame);
        }

        private void jsonComparerBtn_Click(object sender, EventArgs e)
        {
            sumDiffLbl.Text = "Σ differences: ";
            if (JsonDiff(ServerFile, LocalFile) != null)
            {
                LocalWithServerFileComparer(DiffResult);
                ServerWithLocalFileComparer(DiffResult);
            }
        }

        private string CommonURL(string langID, string strings)
        {
            return string.Format(@"https://hg4dev.gahypergaming.com/gameart/games/translations/common/{0}/{1}{2}.json", langID, langID, strings);
        }

        private JObject JsonDiff(JObject serverFile, JObject localFile)
        {
            if (serverFile != null && localFile != null)
            {
                JsonDiffPatch = new JsonDiffPatch();
                if (serverWithLocalChckBox.Checked)
                    DiffResult = (JObject)JsonDiffPatch.Diff(localFile, serverFile);
                else if (localWithServerChckBox.Checked)
                    DiffResult = (JObject)JsonDiffPatch.Diff(serverFile, localFile);
                else if (!localWithServerChckBox.Checked && !serverWithLocalChckBox.Checked)
                    MessageBox.Show("[WARNING]: Please check one of the compare option", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetStatusLabel(DiffResult);
                return DiffResult;
            }
            else
            {
                MessageBox.Show("[WARNING]: Compare files are empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return DiffResult;
        }

        private List<DiffResultProps> DiffListGenerator(JObject customObject)
        {
            List<DiffResultProps> newList = new List<DiffResultProps>();
            if (customObject != null)
            {
                foreach (JProperty item in customObject.Properties())
                {
                    newList.Add(new DiffResultProps(item.Name, item.Value));
                }
                return newList;
            }
            else
            {
                MessageBox.Show("[INFO]: Cannot generate DIFF.");
            }

            return newList;
        }

        private void searchParamter_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = !string.IsNullOrEmpty(searchParamter.Text);
        }

        private List<DiffResultProps> CleanDiffList(JObject diffResult)
        {
            List<DiffResultProps> returnedDiffItem = DiffListGenerator(diffResult);
            List<DiffResultProps> cleanList = new List<DiffResultProps>();
            int outParseParameter = 0;
            if (returnedDiffItem != null)
            {
                foreach (var cleanItem in returnedDiffItem)
                {
                    if (!int.TryParse(cleanItem.DiffResult.Last.ToString(), out outParseParameter))
                        cleanList.Add(new DiffResultProps(cleanItem.DiffProperties, cleanItem.DiffResult));
                }
                return cleanList;
            }
            else
            {
                MessageBox.Show("[ERROR]: Cannot clean you DIFF list no elements were found in the list [CleanDiffList(JObject diffResult)]");
            }
            return cleanList;
        }

        private List<DiffResultProps> ListWithNewPropertieServer(JObject diffResult)
        {
            List<DiffResultProps> returnedDiffItem = DiffListGenerator(diffResult);
            List<DiffResultProps> cleanList = new List<DiffResultProps>();
            if (returnedDiffItem != null)
            {
                //.ToArray() to escape a exception 'Collection was modified; enumeration operation may not execute.'. You cannot excecute modification on List while looping through it
                foreach (var dirtyItem in returnedDiffItem.ToArray())
                {
                    foreach (DataGridViewRow row in serverFileViewGrid.Rows)
                    {
                        if (dirtyItem.DiffProperties != row.Cells[0].Value.ToString() && dirtyItem.DiffResult.First.ToString() != row.Cells[1].Value.ToString())
                        {
                            // TO-DO make this shit better => THIS IS STUPID
                        }
                        else
                        {
                            //Remove properties
                            returnedDiffItem.Remove(dirtyItem);
                        }
                    }
                }
                return returnedDiffItem;
            }
            else
            {
                MessageBox.Show("[ERROR]: Cannot clean you DIFF list no elements were found in the list [ListWithNewPropertieServer(JObject diffResult)]");
            }
            return returnedDiffItem;
        }

        public void CheckForExtraPropertyOnServerFile(JObject diffResult)
        {
            ListWithNewPropertieServer(diffResult);
        }

        public void LocalWithServerFileComparer(JObject diffResult)
        {
            List<DiffResultProps> returnedDiffItem = CleanDiffList(diffResult);
            foreach (DiffResultProps item in returnedDiffItem)
            {
                // 1 => PROPERTY
                if (item.ChildCount == 1)
                {
                    foreach (DataGridViewRow localFileGrid in localFileViewGrid.Rows)
                    {
                        if (localFileGrid.Cells[0].Value.ToString() == item.DiffProperties)
                        {
                            localFileViewGrid.Rows[localFileGrid.Index].Cells[0].Style.BackColor = Color.Salmon;
                        }
                    }
                }
                // 2 => TEXT
                else if (item.ChildCount == 2)
                {
                    foreach (DataGridViewRow localFileGrid in localFileViewGrid.Rows)
                    {
                        if (localFileGrid.Cells[1].Value.ToString() == item.DiffResult.Last.ToString())
                        {
                            localFileViewGrid.Rows[localFileGrid.Index].Cells[1].Style.BackColor = Color.Salmon;
                        }
                    }
                }
            }
        }

        public void ServerWithLocalFileComparer(JObject diffResult)
        {
            List<DiffResultProps> returnedDiffItem = CleanDiffList(diffResult);
            foreach (DiffResultProps item in returnedDiffItem)
            {
                // 1 => PROPERTY
                if (item.ChildCount == 1)
                {
                    foreach (DataGridViewRow serverFileGrid in serverFileViewGrid.Rows)
                    {
                        if (serverFileGrid.Cells[0].Value.ToString() == item.DiffProperties)
                            serverFileViewGrid.Rows[serverFileGrid.Index].DefaultCellStyle.BackColor = Color.Salmon;
                    }
                }
                // 2 => TEXT
                else if (item.ChildCount == 2)
                {
                    foreach (DataGridViewRow serverFileGrid in serverFileViewGrid.Rows)
                    {
                        if (serverFileGrid.Cells[1].Value.ToString() == item.DiffResult.Last.ToString())
                        {
                            serverFileViewGrid.Rows[serverFileGrid.Index].Cells[1].Style.BackColor = Color.Salmon;
                        }
                    }
                }
            }
        }

        private void titleCheckBtn_Click(object sender, EventArgs e)
        {
            ColorAllTitleRows(serverFileViewGrid, localFileViewGrid);
        }

        public void SetStatusLabel(JObject diffResult)
        {
            diffStatusLbl.Text = "Status:";
            if (diffResult == null || diffResult.Count == 0)
            {
                diffStatusLbl.Text = diffStatusLbl.Text += "BOTH FILES ARE THE SAME (CLEAN)";
                diffStatusLbl.ForeColor = Color.MediumSpringGreen;
                sumDiffLbl.Text = sumDiffLbl.Text += 0;
            }
            else if (diffResult != null || diffResult.Count != 0)
            {
                diffStatusLbl.Text = diffStatusLbl.Text += "THERE IS DIFFERENCE BETWEEN \n THESE TWO FILES(DIRTY)";
                diffStatusLbl.ForeColor = Color.Salmon;
                sumDiffLbl.Text = sumDiffLbl.Text += CleanDiffList(diffResult).Count.ToString();
            }
        }

        private void clearColorGridsBtn_Click(object sender, EventArgs e)
        {
            ClearColorOnTheGrids(serverFileViewGrid, localFileViewGrid);
        }

        private void ColorAllTitleRows(DataGridView serverList, DataGridView localList)
        {
            if (serverList.RowCount != 0 || localList.RowCount != 0)
            {
                if (serverList != null)
                {
                    foreach (DataGridViewRow serverRow in serverList.Rows)
                    {
                        if (serverRow.Cells[0].Value.ToString().IndexOf("TITLE") >= 0 /*&& serverRow.Cells[0].Value.ToString().IndexOf("SUBTITLE") <= 0*/)
                            serverList.Rows[serverRow.Index].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                }

                if (localList != null)
                {
                    foreach (DataGridViewRow localRow in localList.Rows)
                    {
                        if (localRow.Cells[0].Value.ToString().IndexOf("TITLE") >= 0 /*&& serverRow.Cells[0].Value.ToString().IndexOf("SUBTITLE") <= 0*/)
                            localList.Rows[localRow.Index].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                }
            }
            else if (serverList.RowCount == 0 && localList.RowCount == 0)
            {
                MessageBox.Show("[INFO]: Please load at least one grid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearColorOnTheGrids(DataGridView serverList, DataGridView localList)
        {
            if (serverList.RowCount != 0 || localList.RowCount != 0)
            {
                if (serverList != null)
                {
                    foreach (DataGridViewRow serverRow in serverList.Rows)
                    {
                        serverList.Rows[serverRow.Index].DefaultCellStyle.BackColor = Color.Empty;
                        // TO-DO Handle this is implemented because of compare
                        serverList.Rows[serverRow.Index].Cells[0].Style.BackColor = Color.Empty;
                        serverList.Rows[serverRow.Index].Cells[1].Style.BackColor = Color.Empty;
                    }
                }

                if (localList != null)
                {
                    foreach (DataGridViewRow localRow in localList.Rows)
                    {
                        localList.Rows[localRow.Index].DefaultCellStyle.BackColor = Color.Empty;
                        // TO-DO Handle this is implemtented because of compare
                        serverList.Rows[localRow.Index].Cells[0].Style.BackColor = Color.Empty;
                        localList.Rows[localRow.Index].Cells[1].Style.BackColor = Color.Empty;
                    }
                }
            }
            else if(serverList.RowCount == 0 && localList.RowCount == 0)
            {
                MessageBox.Show("[INFO]: Please load at least one grid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}