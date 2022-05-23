using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_week_13_23_Mei
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtPlayer = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtTeamNumber = new DataTable();

        public string oldPlayerId = "";
        public string oldPlayerName = "";
        public string oldBirthdate = "";
        public string oldNationality = "";
        public string oldTeam = "";
        public string oldTeamNumber = "";
        int posisiSekarang = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number FROM player p, nationality n, team t WHERE p.nationality_id = n.nationality_id and t.team_id = p.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            DataPemain(0);

            sqlQuery = "SELECT nationality_id, nation FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            cBox_nationality.DataSource = dtNationality;
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DisplayMember = "nation";

            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            cBox_team.DataSource = dtTeam;
            cBox_team.ValueMember = "team_id";
            cBox_team.DisplayMember = "team_name";

        }
 
        public void DataPemain(int DataKe)
        {
            tBox_ID.Text = dtPlayer.Rows[DataKe][0].ToString();
            tBox_Nama.Text = dtPlayer.Rows[DataKe][1].ToString();
            DTP_birthdate.Text = dtPlayer.Rows[DataKe][2].ToString();
            cBox_nationality.Text = dtPlayer.Rows[DataKe][3].ToString();
            cBox_team.Text = dtPlayer.Rows[DataKe][4].ToString();
            numericUpDownTeamNumber.Text = dtPlayer.Rows[DataKe][5].ToString();
            
            oldPlayerId = tBox_ID.Text;
            oldPlayerName =tBox_Nama.Text;
            oldBirthdate = DTP_birthdate.Value.ToString("yyyy-MM-dd");
            oldNationality = cBox_nationality.Text;
            oldTeam = cBox_team.Text;
            oldTeamNumber = numericUpDownTeamNumber.Value.ToString();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        { 
            if (posisiSekarang < dtPlayer.Rows.Count - 1)
            {
                posisiSekarang++;
                DataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            DataPemain(dtPlayer.Rows.Count - 1);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (posisiSekarang > 0)
            {
                posisiSekarang--;
                DataPemain(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            DataPemain(0);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            if (lbl_status.Text=="Not Available")
            {
                MessageBox.Show("Error message: Tidak bisa save karena team number tidak tersedia");
            }
            else if (lbl_status.Text=="Available")
            {
                sqlQuery = $"UPDATE player SET player_id='{tBox_ID.Text}', player_name='{tBox_Nama.Text}', birthdate='{DTP_birthdate.Value.ToString("yyyy-MM-dd")}', nationality_id='{cBox_nationality.SelectedValue.ToString()}', team_id='{cBox_team.SelectedValue.ToString()}', team_number='{numericUpDownTeamNumber.Value.ToString()}' WHERE player_id='{oldPlayerId}' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Data berhasil di save");
            }
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDownTeamNumber_ValueChanged(object sender, EventArgs e)
        {
            TeamNumber();
        }

        private void cBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            TeamNumber();
        }

        private void TeamNumber()
        {
            dtTeamNumber = new DataTable();
            sqlQuery = $"SELECT * FROM player WHERE team_id='{cBox_team.SelectedValue}' and team_number={numericUpDownTeamNumber.Value}";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamNumber);
            
            if (dtTeamNumber.Rows.Count > 0)
            {
                lbl_status.Text = "Not Available";
            }
            else
            {
                lbl_status.Text = "Available";
            }
        }
        
    }
}
