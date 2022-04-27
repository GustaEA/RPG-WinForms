using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.Classes;

namespace RPG
{
    public partial class Form1 : Form
    {
        List<Mobs> listaMobs = new List<Mobs>();
        List<TextBox> txtVidaList = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();            
        }

        //
        //----------------------------------
        //[[[[[[[[[[[[[[CRIA AS TABS COM ATRIBUTOS]]]]]]]]]]]]]]
        //----------------------------------
        //
        void CriaTab()
        {
            string title = txtNomeMob.Text;
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);

            CriarCampos(myTabPage);
        }

        void CriarCampos(TabPage myTabPage)
        {
            Label lblNome = new Label();
            Label lblNivel = new Label();
            Label lblVida = new Label();
            Label lblAtrAtk = new Label();
            Label lblAtrDfs = new Label();
            Label lblMod = new Label();

            TextBox txtNome = new TextBox();
            TextBox txtNivel = new TextBox();
            TextBox txtVida = new TextBox();
            TextBox txtAtrAtk = new TextBox();
            TextBox txtAtrDfs = new TextBox();
            TextBox txtModAtk = new TextBox();
            TextBox txtModDfs = new TextBox();

            myTabPage.Controls.Add(lblNome);
            myTabPage.Controls.Add(lblNivel);
            myTabPage.Controls.Add(lblVida);
            myTabPage.Controls.Add(lblAtrAtk);
            myTabPage.Controls.Add(lblAtrDfs);
            myTabPage.Controls.Add(lblMod);

            myTabPage.Controls.Add(txtNome);
            myTabPage.Controls.Add(txtNivel);
            myTabPage.Controls.Add(txtVida);
            myTabPage.Controls.Add(txtAtrAtk);
            myTabPage.Controls.Add(txtAtrDfs);
            myTabPage.Controls.Add(txtModAtk);
            myTabPage.Controls.Add(txtModDfs);

            PosicionaCampos(lblNome, lblNivel, lblVida, lblAtrAtk, lblAtrDfs, lblMod, txtNome, txtNivel, txtVida, txtAtrAtk, txtAtrDfs, txtModAtk, txtModDfs);

            txtVidaList.Add(txtVida);
        }

        void PosicionaCampos(Label lblNome, Label lblNivel, Label lblVida, Label lblAtrAtk, Label lblAtrDfs, Label lblMod, TextBox txtNome, TextBox txtNivel, TextBox txtVida, TextBox txtAtrAtk, TextBox txtAtrDfs, TextBox txtModAtk, TextBox txtModDfs)
        {
            int listaIndex = tabControl1.TabCount - 1;

            lblNome.Location = new Point(14, 17);
            lblNome.Size = new Size(40, 13);
            lblNome.Text = "Nome:";
            txtNome.Location = new Point(58, 13);
            txtNome.Size = new Size(100, 20);
            txtNome.ReadOnly = true;
            txtNome.Text = listaMobs[listaIndex].Nome;

            lblNivel.Location = new Point(14, 43);
            lblNivel.Size = new Size(36, 13);
            lblNivel.Text = "Nível:";
            txtNivel.Location = new Point(58, 40);
            txtNivel.Size = new Size(36, 20);
            txtNivel.ReadOnly = true;
            txtNivel.Text = listaMobs[listaIndex].Nivel.ToString();

            lblVida.Location = new Point(14, 71);
            lblVida.Size = new Size(31, 13);
            lblVida.Text = "Vida:";
            txtVida.Location = new Point(58, 68);
            txtVida.Size = new Size(36, 20);
            txtVida.ReadOnly = true;
            txtVida.Text = listaMobs[listaIndex].VidaAtual.ToString();

            lblAtrAtk.Location = new Point(14, 131);
            lblAtrAtk.Size = new Size(65, 13);
            lblAtrAtk.Text = "Atr. de ATK:";
            txtAtrAtk.Location = new Point(85, 128); 
            txtAtrAtk.Size = new Size(30, 20);
            txtAtrAtk.ReadOnly = true;
            txtAtrAtk.Text = listaMobs[listaIndex].AtributoAtk1.ToString();

            lblAtrDfs.Location = new Point(14, 176);
            lblAtrDfs.Size = new Size(65, 13);
            lblAtrDfs.Text = "Atr. de DFS:";
            txtAtrDfs.Location = new Point(85, 173);
            txtAtrDfs.Size = new Size(30, 20);
            txtAtrDfs.ReadOnly = true;
            txtAtrDfs.Text = listaMobs[listaIndex].AtributoDfs1.ToString();

            lblMod.Location = new Point(117, 112);
            lblMod.Size = new Size(31, 13);
            lblMod.Text = "Mod:";
            txtModAtk.Location = new Point(118, 128);
            txtModAtk.Size = new Size(30, 20);
            txtModAtk.ReadOnly = true;
            txtModAtk.Text = listaMobs[listaIndex].ModAtk1.ToString();
            txtModDfs.Location = new Point(118, 173);
            txtModDfs.Size = new Size(30, 20);
            txtModDfs.ReadOnly = true;
            txtModDfs.Text = listaMobs[listaIndex].ModDfs1.ToString();
        }

        Mobs CriaMob1()
        {
            string nome;
            int nivel;
            int vida;
            int atrATK;
            int atrDFS;

            int num;

            nome = txtNomeMob.Text;
            nivel = int.TryParse(txtNivelMob.Text, out num) ? num : -1;
            vida = int.TryParse(txtVidaMob.Text, out num) ? num : -1;
            atrATK = int.TryParse(txtMobAtrATK.Text, out num) ? num : -1;
            atrDFS = int.TryParse(txtMobAtrDFS.Text, out num) ? num : -1;

            Mobs novoMob = new Mobs(nome, nivel, vida, atrATK, atrDFS);
            return novoMob;
        }

        //
        //----------------------------------
        //[[[[[[[[[[[[[[METODOS REUTILIZÁVEIS]]]]]]]]]]]]]]
        //----------------------------------
        //
        private void RdnDados(Random rdn, int numDadoInt, out int maxNum, int minNum, out int numRdn)
        {
            maxNum = (numDadoInt + 1) * minNum;
            numRdn = rdn.Next(minNum, maxNum);
            txtResDado.Text = numRdn.ToString();
        }
        //
        //----------------------------------
        //[[[[[[[[[[[[[[EVENTO-BOTÕES]]]]]]]]]]]]]]
        //----------------------------------
        //
        private void CriarMob(object sender, EventArgs e)
        {
            Mobs mob = CriaMob1();
            listaMobs.Add(mob);
            CriaTab();            
            txtNomeMob.Clear();
            txtNivelMob.Clear();
            txtVidaMob.Clear();
            txtMobAtrATK.Clear();
            txtMobAtrDFS.Clear();
        }

        private void DarDano(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            int num;
            int danoINT;

            danoINT = int.TryParse(txtValor.Text, out num) ? num : 0;

            listaMobs[index].VidaAtual -= danoINT;
            txtVidaList[index].Text = listaMobs[index].VidaAtual.ToString();

            if(listaMobs[index].VidaAtual <= 0)
            {
                listaMobs.RemoveAt(index);
                txtVidaList.RemoveAt(index);
                tabControl1.TabPages.RemoveAt(index);
            }
        }

        private void AddVida(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            int num;
            int vidaINT;

            vidaINT = int.TryParse(txtValor.Text, out num) ? num : 0;
            
            listaMobs[index].VidaAtual += vidaINT;
            txtVidaList[index].Text = listaMobs[index].VidaAtual.ToString();
        }

        private void RolarDados(object sender, EventArgs e)
        {
            Random rdn = new Random();

            int num;
            int numDadoInt;
            int maxNum;
            int minNum = int.TryParse(qtdDado.Value.ToString(), out num) ? num : 0;
            int numRdn;

            switch (tipoDado.SelectedIndex)
            {
                case 0:
                    numDadoInt = 4;
                    RdnDados(rdn, numDadoInt, out maxNum, minNum, out numRdn);
                    break;
                case 1:
                    numDadoInt = 6;
                    RdnDados(rdn, numDadoInt, out maxNum, minNum, out numRdn);
                    break;
                case 2:
                    numDadoInt = 10;
                    RdnDados(rdn, numDadoInt, out maxNum, minNum, out numRdn);
                    break;
                case 3:
                    numDadoInt = 12;
                    RdnDados(rdn, numDadoInt, out maxNum, minNum, out numRdn);
                    break;
                case 4:
                    numDadoInt = 20;
                    RdnDados(rdn, numDadoInt, out maxNum, minNum, out numRdn);
                    break;
            }            
        }

        private void JogadaATK(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int index = tabControl1.SelectedIndex;            

            int numRdn = rdn.Next(1, 21);
            txtD20.Text = numRdn.ToString();

            txtModD20.Text = listaMobs[index].ModAtk1.ToString();

            int res = numRdn + listaMobs[index].ModAtk1;
            if(res < 0)
            {
                res = 0;
            }
            txtResD20.Text = res.ToString();
        }

        private void JogadaDFS(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int index = tabControl1.SelectedIndex;

            int numRdn = rdn.Next(1, 21);
            txtD20.Text = numRdn.ToString();

            txtModD20.Text = listaMobs[index].ModDfs1.ToString();

            int res = numRdn + listaMobs[index].ModDfs1;
            if (res < 0)
            {
                res = 0;
            }
            txtResD20.Text = res.ToString();
        }
    }
}
