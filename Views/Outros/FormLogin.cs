using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
using EscalasMetodista.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista
{
    public partial class FormLogin : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT idPessoa, nome, sobrenome, email, senha, tipoUsuario_fk FROM pessoa " +
                              "WHERE email = '" + txtEmail.Text +
                              "' COLLATE SQL_Latin1_General_CP1_CS_AS AND senha = '" + txtSenha.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND status = 'Ativo' AND tipoUsuario_fk <> 3";

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    FormMenu formMenu = new FormMenu();

                    UsuarioSession.tipoUsuario = Convert.ToInt32(dr[5].ToString());
                    UsuarioSession.idUsuario = Convert.ToInt32(dr[0].ToString());
                    UsuarioSession.nomeUsuario = dr[1].ToString();
                    UsuarioSession.sobrenomeUsuario = dr[2].ToString();

                    formMenu.Show();
                    this.Hide();
                    return;
                }
                lbErro.Text = "* Usuário e/ou Senha incorretos";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            checkMostrarSenha.CheckState = CheckState.Unchecked;
            txtEmail.Text = "E-mail";
            txtSenha.UseSystemPasswordChar = false;
            txtSenha.Text = "Senha";
            lbErro.Text = null;
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarSenha.Checked)
                txtSenha.UseSystemPasswordChar = false;
            else
                txtSenha.UseSystemPasswordChar = true;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnEntrar_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btnLimpar_MouseHover(object sender, EventArgs e)
        {
            btnLimpar.BackColor = SystemColors.Control;
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.IconColor = Color.Black;
            btnLimpar.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.IconColor = SystemColors.Control;
            btnLimpar.FlatAppearance.BorderColor = SystemColors.Control;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("E-mail"))
            {
                txtEmail.Text = null;

                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    txtSenha.UseSystemPasswordChar = false;
                    txtSenha.Text = "Senha";
                }
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("Senha"))
            {
                txtSenha.Text = null;
                txtSenha.UseSystemPasswordChar = true;

                if (string.IsNullOrEmpty(txtEmail.Text))
                    txtEmail.Text = "E-mail";
            }
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ActiveControl = btnEntrar;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
