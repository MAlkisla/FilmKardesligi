using FilmKardesligi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FilmKardesligi
{
    public partial class Form1 : Form
    {
        FilmKardesligiContext db = new FilmKardesligiContext();
        public Form1()
        {
            InitializeComponent();
            FilmleriListele();
            TurleriListele();
        }

        private void TurleriListele()
        {
            clbTur.DataSource = db.Turler.OrderBy(x => x.TurAd).ToList();
            clbTur.DisplayMember = "TurAd";
        }

        private void FilmleriListele()
        {
            lstFilmler.DataSource = db.Filmler.OrderByDescending(x => x.Puan).ThenBy(x => x.FilmAd).ToList();
        }

        private void tsmiTurler_Click(object sender, EventArgs e)
        {
            TurlerForm frmTurler = new TurlerForm(db);
            frmTurler.DegisiklikYapildi += FrmTurler_DegisiklikYapildi;
            frmTurler.ShowDialog();
        }

        private void FrmTurler_DegisiklikYapildi(object sender, EventArgs e)
        {
            TurleriListele();
            FilmleriListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string filmAd = txtFilmAd.Text.Trim();
            int puan = Convert.ToInt32(
                gboPuan
                .Controls.OfType<RadioButton>()
                .FirstOrDefault(x => x.Checked)
                .Tag);
            List<Tur> seciliTurler = clbTur.CheckedItems.OfType<Tur>().ToList();

            if (filmAd == "")
            {
                MessageBox.Show("Film adı girmediniz!");
                return;
            }
            if (clbTur.CheckedItems.Count == 0)
            {
                MessageBox.Show("Film için en az bir tür seçmelisiniz!");
                return;
            }

            if (duzenlenen == null)
            {
                Film film = new Film
                {
                    FilmAd = filmAd,
                    Puan = puan,
                    Turler = seciliTurler
                };
                db.Filmler.Add(film);
            }
            else
            {
                duzenlenen.FilmAd = filmAd;
                duzenlenen.Puan = puan;
                duzenlenen.Turler = seciliTurler;
            }
            db.SaveChanges();
            FormuResetle();
            FilmleriListele();

        }

        private void FormuTemizle()
        {
            txtFilmAd.Clear();
            clbTur.ClearSelected();
            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                clbTur.SetItemChecked(i, false);
            }
            rbPuan3.Checked = true;
        }
        private void FormuResetle()
        {
            duzenlenen = null;
            FormuTemizle();
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            lstFilmler.Enabled = btnFilmDuzenle.Enabled = btnFilmSil.Enabled = true;
            txtFilmAd.Focus();
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Silmek için bir öğe seçmelisiniz.");
                return;
            }
            Film film = (Film)lstFilmler.SelectedItem;

            db.Filmler.Remove(film);
            db.SaveChanges();
            FilmleriListele();
            lstFilmler.SelectedIndex = sid < lstFilmler.Items.Count ? sid : lstFilmler.Items.Count - 1;
        }
        Film duzenlenen = null;
        private void btnFilmDuzenle_Click(object sender, EventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Düzenlemek için bir öğe seçmelisiniz.");
                return;
            }
            FormuTemizle();
            duzenlenen = (Film)lstFilmler.SelectedItem;
            txtFilmAd.Text = duzenlenen.FilmAd;

            for (int i = 0; i < clbTur.Items.Count; i++)
            {
                Tur tur = (Tur)clbTur.Items[i];
                if (duzenlenen.Turler.Any(x => x.Id == tur.Id))
                {
                    clbTur.SetItemChecked(i, true);
                }
            }

            gboPuan.Controls.OfType<RadioButton>().FirstOrDefault(x => (string)x.Tag == duzenlenen.Puan.ToString()).Checked = true;

            btnIptal.Show();
            btnEkle.Text = "KAYDET";
            lstFilmler.Enabled = btnFilmDuzenle.Enabled = btnFilmSil.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
