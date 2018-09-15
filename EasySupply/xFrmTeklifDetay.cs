using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EasySupply
{
    public partial class xFrmTeklifDetay : DevExpress.XtraEditors.XtraForm
    {
        public void SetCurrencyAndLangs()
        {
            try
            {
                this.filterGroupControl.Text = L.ArsivdekiBilgileriSuz;
                this.lblIlkTarih.Text = L.TarihIlk;
                this.lblSonTarih.Text = L.TarihSon;
                this.suzButton.Text = L.Suz;
                this.lblBekliyor.Text = L.Teklif_BEKLIYOR;
                this.lblOnaylandi.Text = L.Teklif_ONAYLANDI;
                this.lblIptal.Text = L.Teklif_IPTAL;

                this.colGemiAdi.Caption = lblGemiAdi.Text = L.GemiAdi;
                this.colBaglamaLimani.Caption = L.BaglamaLimani;
                this.colAcenta.Caption = L.Acenta;
                this.colManager.Caption = L.Manager;
                this.colHazirlayan.Caption = L.Hazirlayan;
                this.colTasimaUcreti.Caption = L.TasimaUcreti;
                this.colTarih.Caption = L.Tarih;
                this.colDurum.Caption = L.Durum;
                this.colDurumNotu.Caption = L.Not;
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTD", 1) + ex.Message);
            }
        }
        public void GetTeklifler()
        {
            try
            {
                DataSet ds = TeklifMethods.GetRelation(this.ilkTarihDateEdit.DateTime, this.sonTarihDateEdit.DateTime, this.gemiAdiTextEdit.Text);
                this.teklifBindingSource.DataSource = ds.Tables[0];
                this.teklifGridControl.ForceInitialize();
                DevExpress.XtraGrid.Views.Grid.GridView grdDetailView = new DevExpress.XtraGrid.Views.Grid.GridView(this.teklifGridControl);
                this.teklifGridControl.LevelTree.Nodes.Add("FK_Teklif_TO_Detay", grdDetailView);
                grdDetailView.ViewCaption = "Teklif Detayları";
                grdDetailView.PopulateColumns(ds.Tables[1]);
                grdDetailView.OptionsView.ShowFooter = true;
                grdDetailView.OptionsView.ShowGroupPanel = false;
                grdDetailView.OptionsBehavior.AutoSelectAllInEditor = false;
                grdDetailView.OptionsBehavior.Editable = false;
                grdDetailView.OptionsBehavior.AutoExpandAllGroups = true;
                grdDetailView.OptionsSelection.EnableAppearanceFocusedCell = false;
                grdDetailView.OptionsView.EnableAppearanceEvenRow = true;
                grdDetailView.GroupCount = 1;
                grdDetailView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
                new DevExpress.XtraGrid.Columns.GridColumnSortInfo(grdDetailView.Columns[2], DevExpress.Data.ColumnSortOrder.Ascending)});
                byte index = 0;
                grdDetailView.Columns[index++].VisibleIndex = -1;
                //TeklifID,UrunAdi,FirmaBilgi,Adet,Birim,BirimFiyati,KarOrani
                string[] kolonIsimleri = { L.UrunAciklama, L.TedarikciFirma, L.Miktar, L.Birim, L.AlisFiyati, L.KarOrani, L.SatisFiyati, L.AlisTutar, L.SatisTutar, L.NetKar };
                DevExpress.XtraGrid.Columns.GridColumn c = null;
                string kolon = "";
                for (int i = 0; i < kolonIsimleri.Length; i++)
                {
                    kolon = kolonIsimleri[i];
                    switch (i)
                    {
                        case 6:
                            c = new DevExpress.XtraGrid.Columns.GridColumn();
                            c.VisibleIndex = -1;
                            c.Name = "colSatisFiyati";
                            c.FieldName = c.Name;
                            c.Caption = kolon;
                            c.UnboundExpression = "([BirimFiyati] + ([BirimFiyati] * [KarOrani]))";
                            c.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            grdDetailView.Columns.Add(c);
                            break;
                        case 7:
                            c = new DevExpress.XtraGrid.Columns.GridColumn();
                            c.VisibleIndex = 9;
                            c.Name = "colAlisTutar";
                            c.FieldName = c.Name;
                            c.Caption = kolon;
                            c.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, c.Name, Commons.Kur0FormatCustom)});
                            c.UnboundExpression = "[BirimFiyati] * [Adet]";
                            c.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            grdDetailView.Columns.Add(c);
                            break;
                        case 8:
                            c = new DevExpress.XtraGrid.Columns.GridColumn();
                            c.VisibleIndex = 10;
                            c.Name = "colSatisTutar";
                            c.FieldName = c.Name;
                            c.Caption = kolon;
                            c.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, c.Name, Commons.Kur0FormatCustom)});
                            c.UnboundExpression = "([BirimFiyati] + ([BirimFiyati] * [KarOrani])) * [Adet]";
                            c.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            grdDetailView.Columns.Add(c);
                            break;
                        case 9:
                            c = new DevExpress.XtraGrid.Columns.GridColumn();
                            c.VisibleIndex = 11;
                            c.Name = "colNetKar";
                            c.FieldName = c.Name;
                            c.Caption = kolon;
                            c.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, c.Name, Commons.Kur0FormatCustom)});
                            c.UnboundExpression = "([BirimFiyati] * [KarOrani]) * [Adet]";
                            c.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
                            grdDetailView.Columns.Add(c);
                            break;
                        case 4:
                        case 5:
                            grdDetailView.Columns[index].Caption = kolon;
                            grdDetailView.Columns[index].VisibleIndex = -1;
                            break;
                        default:
                            grdDetailView.Columns[index].Caption = kolon;
                            break;
                    }
                    index++;
                }
                grdDetailView.Columns[1].Width = 300;
                grdDetailView.Columns[2].Width = 200;
                for (int i = 3; i < index; i++)
                {
                    grdDetailView.Columns[i].OptionsColumn.AllowSize = false;
                    if (i != 3 & i != 4 & i != 6 & i != 7)
                    {
                        grdDetailView.Columns[i].Width = 70;
                        grdDetailView.Columns[i].DisplayFormat.FormatString = Commons.Kur0Format;
                        grdDetailView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    }
                    else if (i == 3)
                        grdDetailView.Columns[i].Width = 40;
                    else if (i == 4)
                        grdDetailView.Columns[i].Width = 40;
                    else if (i == 6)
                    {
                        grdDetailView.Columns[i].DisplayFormat.FormatString = "% ##0";
                        grdDetailView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        grdDetailView.Columns[i].Width = 40;
                    }
                    else if (i == 7)
                    {
                        grdDetailView.Columns[i].DisplayFormat.FormatString = "##0";
                        grdDetailView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                        grdDetailView.Columns[i].Width = 40;
                    }
                }
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTD", 2) + ex.Message);
            }
        }

        public xFrmTeklifDetay()
        {
            InitializeComponent();
            SetCurrencyAndLangs();
        }

        private void xFrmTeklifDetay_Load(object sender, EventArgs e)
        {
            Commons.Status(this.Text + " ekranı açıldı.");
            this.ilkTarihDateEdit.DateTime = DateTime.Now.AddDays(-7);
            this.sonTarihDateEdit.DateTime = DateTime.Now;
            GetTeklifler();
        }

        private void teklifGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                xFrmTeklif frm = new xFrmTeklif();
                frm.MdiParent = this.MdiParent;
                frm.TeklifObject = TeklifMethods.GetTeklif(BAYMYO.UI.Converts.NullToInt64(teklifGridView.GetFocusedRowCellValue("ID")));
                frm.Name = "frm" + frm.TeklifObject.ID;
                Commons.IsOpenForm(frm);
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("FTD", 3) + ex.Message);
            }
        }

        private void suzButton_Click(object sender, EventArgs e)
        {
            GetTeklifler();
        }
    }
}