using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        // se existir 
        string dropMV =
            "-- Apaga indice espacial \n" +
            "drop index idepbh.XXX_sx; \n \n" +
            "-- Dropa view materializada \n" +
            "drop materialized view IDEPBH.XXX;\n\n" +
            "--Apaga metadados espacial \n" +
            "delete from mdsys.sdo_geom_metadata_table m \n" +
              "where \n" +
               " m.sdo_owner = 'IDEPBH' \n" +
               " and \n" +
               " m.sdo_table_name = 'XXX' \n" +
               " and \n" +
               " m.sdo_column_name = 'GEOMETRIA';  \n";

        // script para criacao 
        string createMV =
            "-- Cria view materializada \n" +
            "create materialized view IDEPBH.XXX \n" +
            "nologging \n" +
            "noparallel \n" +
            "build BUILD_TYPE \n" +
            "refresh force on demand \n" +
            "start with REFRESH_VIEW \n" +
            "next REFRESH_VIEW \n" +
            "as \n" +
            "select \n" +
            "    COLUMNS \n" +
            "  from \n" +
            "    SCHEMA.XXX@dbl_geoprod_bhmap.pbh bp; \n\n" +

            "--Cadastra metadados espacial  \n" +
            "insert into mdsys.sdo_geom_metadata_table (sdo_owner, sdo_table_name, sdo_column_name,  sdo_diminfo,  sdo_srid)  \n" +
            "  values('IDEPBH',  \n" +
             "         'XXX',  \n" +
             "         'GEOMETRIA',  \n" +
             "         mdsys.sdo_dim_array (  \n" +
             "           mdsys.sdo_dim_element ('X', 598487.098431027, 619327.974503302, .001), \n" +
             "           mdsys.sdo_dim_element ('Y', 7781771.42414864, 7812877.3181585, .001)), \n" +
             "         31983); \n\n";


        string createIndex =
         "--Cria indice espacial \n" +
        "create index idepbh.XXX_sx \n" +
        "  on idepbh.XXX(geometria)  \n" +
        "  indextype is mdsys.spatial_index \n" +
        "  parameters('tablespace=geocorp work_tablespace=geocorp_sx layer_gtype=GEOM_TYPE'); \n\n";

        String createGrant =
        "-- Grants \n" +
        "grant select on idepbh.XXX to app_idepbh_geoserver; \n\n" +

        "-- Sinonimo para usurio do Geoserver \n" +
        "create or replace synonym app_idepbh_geoserver.XXX for idepbh.XXX; \n\n"
        ;

        String grantSelect =
        "-- Permissao de acesso aos dados \n" +
        "grant select on OWNERGRANT.TABLENAMEGRANT to LK_BHMAP_GEOC;";

        String coment =
        "comment on column idepbh.TABLE.ROWN_NAME is 'COMENT'; \n";


        public Form1()
        {
            InitializeComponent();
        }

        private string connectdataBase(string owner, string tableName)
        {
            //string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id=hr;Password=hradmin;";

            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST =s324-prodabel.pbh)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = GEODSV1)));" + "User Id=tinorberto;Password=tiago123;";

            string names = "";
            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            OracleCommand oraCommand = new OracleCommand("select COLUMN_NAME from all_tab_columns where table_name =:tableName and owner =:owner", con);
            oraCommand.BindByName = true;
            oraCommand.Parameters.Add(new OracleParameter("owner", owner));
            oraCommand.Parameters.Add(new OracleParameter("tableName", tableName));
            OracleDataReader oraReader = null;
            oraReader = oraCommand.ExecuteReader();

            if (oraReader.HasRows)
            {
                while (oraReader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                    row.Cells[0].Value = oraReader.GetString(0);
                    row.Cells[1].Value = oraReader.GetString(0);
                    dataGrid.Rows.Add(row);

                    //
                    names += oraReader.GetString(0) + " ,";

                }
            }
            else
            {
                names = "No Rows Found";
            }
            // Close and Dispose OracleConnection
            con.Close();
            con.Dispose();

            return names;

        }

        private string createComboxSchema(string owner, string tableName)
        {
            //string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id=hr;Password=hradmin;";

            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST =s324-prodabel.pbh)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = GEODSV1)));" + "User Id=tinorberto;Password=tiago123;";

            string names = "";
            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            OracleCommand oraCommand = new OracleCommand("select COLUMN_NAME from all_tab_columns where table_name =:tableName and owner =:owner", con);
            oraCommand.BindByName = true;
            oraCommand.Parameters.Add(new OracleParameter("owner", owner));
            oraCommand.Parameters.Add(new OracleParameter("tableName", tableName));
            OracleDataReader oraReader = null;
            oraReader = oraCommand.ExecuteReader();

            if (oraReader.HasRows)
            {
                while (oraReader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                    row.Cells[0].Value = oraReader.GetString(0);
                    row.Cells[1].Value = oraReader.GetString(0);
                    dataGrid.Rows.Add(row);

                    //
                    names += oraReader.GetString(0) + " ,";

                }
            }
            else
            {
                names = "No Rows Found";
            }
            // Close and Dispose OracleConnection
            con.Close();
            con.Dispose();

            return names;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void generatebutton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Error Message", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // substituir o nome
            string name = nametextBox.Text;
            string result = Regex.Replace(dropMV, "XXX", name.ToUpper());

            string typeGeom = this.typeGeomcomboBox.GetItemText(this.typeGeomcomboBox.SelectedItem);


            string resultCreate = Regex.Replace(createMV, "XXX", name.ToUpper());
            // schema
            resultCreate = Regex.Replace(resultCreate, "SCHEMA", schemaTextBox.Text.ToUpper());

            //
            // construcao
            if (checkImmediate.Checked == true)
            {
                resultCreate = Regex.Replace(resultCreate, "BUILD_TYPE", " immediate  ");
            }
            else
            {
                resultCreate = Regex.Replace(resultCreate, "BUILD_TYPE", " DEFERRED ");
                //dois minutos
                resultCreate = resultCreate.Replace("REFRESH_VIEW", " sysdate + 2/24/60 ");
            }

            //atualizacao  trunc(sysdate) + 7 + ((1 / 24 / 60) * 6)
            string refresh = this.refreshComboBox.GetItemText(this.refreshComboBox.SelectedItem);
            if (refresh == "SEMANAL")
            {
                resultCreate = Regex.Replace(resultCreate, "REFRESH_VIEW", "trunc(sysdate) + 7 + ((1 / 24 / 60) * 6) ");
            }
            else if (refresh == "DIARIO")
            {
                resultCreate = Regex.Replace(resultCreate, "REFRESH_VIEW", "trunc(sysdate) + 1 + ((1 / 24 / 60) * 6)");
            }
            else
            {
                resultCreate = Regex.Replace(resultCreate, "REFRESH_VIEW", " ADD_MONTHS (sysdate , 1)");
            }

            if (typeGeom != "NENHUM")
            {
                string stringIndex = Regex.Replace(createIndex, "XXX", name.ToUpper());
                resultCreate += Regex.Replace(stringIndex, "GEOM_TYPE", typeGeom.Replace(" ", ""));
            }
            resultCreate += Regex.Replace(createGrant, "XXX", name.ToUpper());
            resultTextBox.Text = result + "\n" + resultCreate;

            if (findColumnsBox1.Checked == true)
            {
                string columns = this.connectdataBase(tableOwnertextBox2.Text.ToUpper(), tableNameTextBox.Text.ToUpper());
                if (columns.Contains(","))
                {
                    columns = columns.Substring(0, columns.LastIndexOf(","));
                    columns = Regex.Replace(columns, ",", ", \n");
                    resultTextBox.Text = Regex.Replace(resultTextBox.Text, "COLUMNS", columns);
                }
                //Permissao de acesso aso dados
                resultTextBox.Text += Regex.Replace(grantSelect, "OWNERGRANT", tableOwnertextBox2.Text.ToUpper());
                resultTextBox.Text = Regex.Replace(resultTextBox.Text, "TABLENAMEGRANT", tableNameTextBox.Text.ToUpper());
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeGridButton_Click(object sender, EventArgs e)
        {
            // remover as linhas
            foreach (DataGridViewCell oneCell in dataGrid.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGrid.Rows.RemoveAt(oneCell.RowIndex);
            }
            
        }

        private void comentButton_Click(object sender, EventArgs e)
        {
            String coments = "";
            //Montar o comentario
            foreach (DataGridViewRow row in dataGrid.Rows)
            {

                if (row.Cells[1].Value != null && row.Cells[2].Value != null )
                {
                string viewName = row.Cells[1].Value.ToString();
                string viewComent = row.Cells[2].Value.ToString();

                string comentText = coment;
                //idepbh.TABLE.ROWN_NAME is 'COMENT'
                comentText = Regex.Replace(comentText, "TABLE", nametextBox.Text.ToUpper());
                comentText = Regex.Replace(comentText, "ROWN_NAME", viewName);
                comentText = Regex.Replace(comentText, "COMENT", viewComent);

                coments += comentText;
                }
             }
            resultTextBox.Text = "-- Comentarios \n"+coments + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
