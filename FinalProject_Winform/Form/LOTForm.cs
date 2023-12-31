﻿using BarcodeStandard;
using FinalProject_Winform.Models.domain;
using FinalProject_Winform.Repositories;
using Microsoft.IdentityModel.Tokens;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace FinalProject_Winform
{
    public partial class LOTForm : Form
    {
        private ILotRepository lotRepository;
        private IProcessRepository processRepository;
        private ILothistoryRepository lothistoryRepository;
        private MainForm mainForm;
        public LOTForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            lotRepository = new LotRepository();
            processRepository = new ProcessRepository();
            lothistoryRepository = new LothistoryRepository();
        }
        //
        DataGridView dgv_lot;
        DataGridView dgv_history;

        private void LOTForm_Load(object sender, EventArgs e)
        {
            dgv_lot = Dgv_Lot;
            dgv_history = dgv_history1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_item.Text == "제품선택" || textBox_count.Text.IsNullOrEmpty())
            {
                MessageBox.Show("제품과 수량을 입력해주세요");
            }
            else
            {
                string bartext = makebarcode();
                while (true)
                {
                    bool result = lotRepository.FindAsync(bartext);
                    if (result)
                    {
                        break;
                    }
                }
                //복사하기
                Clipboard.SetText(bartext);

                lbl_barcode.Text = bartext;
                lbl_text_item.Text = comboBox_item.Text;
                lbl_text_count.Text = textBox_count.Text;

            }


            string barcodeText = lbl_barcode.Text.Trim();
            if (string.IsNullOrEmpty(barcodeText)) { return; }

            Barcode barcode = new();

            SKImage img = barcode.Encode(
                BarcodeStandard.Type.Ean13   // Barcode type
                , barcodeText                // 변환할 텍스트
                , new SKColor(0, 0, 0)       // fore color (바코드 색상) r,g,b
                , new SKColor(0, 0, 0, 0)   // back color (배경 색상)  r,g,b,a
                , (int)(picture_Barcode.Width)   // width
                , (int)(picture_Barcode.Height) // height
                );

            picture_Barcode.Image = Image.FromStream(img.Encode().AsStream());


        }

        private string makebarcode()
        {
            const int length = 12;             //바코드의 길이
            const string chars = "0123456789"; //바코드에 사용할 문자
            StringBuilder sb = new StringBuilder(length); //문자가 저장될 문자열
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lotRepository.AddLotAsync(lbl_text_item.Text, lbl_barcode.Text, int.Parse(lbl_text_count.Text)) != null)
            {
                MessageBox.Show("Lot이 생성되었습니다");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                string formName = button.Name.Replace("btn_", "");
                this.Close();
                FormUtility.OpenForm(formName, mainForm);
            }
        }

        //메인폼으로 돌아가기
        private void LOTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainForm.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 0;
            string text = "";
            if (ComboSearch.Text == "전체검색")
            {
                MessageBox.Show("전체");
                LoadItems(text, num);
            }
            else if (ComboSearch.Text == "품명")
            {
                MessageBox.Show("품명");
                num = 1;
                text = txt_text.Text;
                LoadItems(text, num);
            }
            else
            {
                MessageBox.Show("바코드");
                num = 2;
                text = txt_text.Text;
                LoadItems(text, num);
            }

        }

        private async void LoadItems(string text, int num)
        {
            if (num == 0)
            {
                var Lots = await lotRepository.GetAllAsync();

                //DataGridvIEW 저체 클리어
                dgv_lot.Rows.Clear();
                dgv_lot.Refresh();

                int i = 0;
                foreach (var Lot in Lots)
                {
                    string lot_break;
                    if (Lot.Lot_break == false)
                    {
                        lot_break = "불량";
                    }
                    else { lot_break = "정상"; }
                    dgv_lot.Rows.Add();  // 새로운 row 추가
                    dgv_lot.Rows[i].Cells["Lot_Id"].Value = Lot.Id;
                    dgv_lot.Rows[i].Cells["Lot_Barcode"].Value = Lot.Lot_barcode;
                    dgv_lot.Rows[i].Cells["Lot_Itemid"].Value = Lot.Item.Item_name;
                    dgv_lot.Rows[i].Cells["Lot_amount"].Value = Lot.Lot_amount;
                    dgv_lot.Rows[i].Cells["Lot_status"].Value = Lot.Lot_status;
                    dgv_lot.Rows[i].Cells["Lot_break"].Value = lot_break;
                    dgv_lot.Rows[i].Cells["Lot_regdata"].Value = Lot.Lot_regDate;
                    i++;
                }
            }
            if (num == 1)
            {
                var Lots = await lotRepository.GetByItem(text);

                //DataGridvIEW 저체 클리어
                dgv_lot.Rows.Clear();
                dgv_lot.Refresh();

                int i = 0;
                foreach (var Lot in Lots)
                {
                    string lot_break;
                    if (Lot.Lot_break == false)
                    {
                        lot_break = "불량";
                    }
                    else { lot_break = "정상"; }
                    dgv_lot.Rows.Add();  // 새로운 row 추가
                    dgv_lot.Rows[i].Cells["Lot_Id"].Value = Lot.Id;
                    dgv_lot.Rows[i].Cells["Lot_Barcode"].Value = Lot.Lot_barcode;
                    dgv_lot.Rows[i].Cells["Lot_Itemid"].Value = Lot.Item.Item_name;
                    dgv_lot.Rows[i].Cells["Lot_amount"].Value = Lot.Lot_amount;
                    dgv_lot.Rows[i].Cells["Lot_status"].Value = Lot.Lot_status;
                    dgv_lot.Rows[i].Cells["Lot_break"].Value = lot_break;
                    dgv_lot.Rows[i].Cells["Lot_regdata"].Value = Lot.Lot_regDate;
                    i++;
                }
            }
            if (num == 2)
            {
                var Lots = await lotRepository.GetByBarcode(text);

                //DataGridvIEW 저체 클리어
                dgv_lot.Rows.Clear();
                dgv_lot.Refresh();
                int i = 0;
                foreach (var Lot in Lots)
                {
                    string lot_break;
                    if (Lot.Lot_break == false)
                    {
                        lot_break = "불량";
                    }
                    else { lot_break = "정상"; }
                    dgv_lot.Rows.Add();  // 새로운 row 추가
                    dgv_lot.Rows[i].Cells["Lot_Id"].Value = Lot.Id;
                    dgv_lot.Rows[i].Cells["Lot_Barcode"].Value = Lot.Lot_barcode;
                    dgv_lot.Rows[i].Cells["Lot_Itemid"].Value = Lot.Item.Item_name;
                    dgv_lot.Rows[i].Cells["Lot_amount"].Value = Lot.Lot_amount;
                    dgv_lot.Rows[i].Cells["Lot_status"].Value = Lot.Lot_status;
                    dgv_lot.Rows[i].Cells["Lot_break"].Value = lot_break;
                    dgv_lot.Rows[i].Cells["Lot_regdata"].Value = Lot.Lot_regDate;
                    i++;
                }
            }
        }

        private async void btn_start_search_Click(object sender, EventArgs e)
        {
            loadLot();
        }
        public async void loadLot()
        {
            string text = tbox_start_lotnum.Text;
            var Lots = await lotRepository.GetByBarcode(text);
            foreach (var Lot in Lots)
            {
                lbl_start_lotnum.Text = Lot.Lot_barcode;
                lbl_start_item.Text = Lot.Item.Item_name;
                lbl_start_amount.Text = Lot.Lot_amount.ToString();
                lbl_start_status.Text = Lot.Lot_status;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string ing = cmb_process.Text + "ing";
            if (lotRepository.FindLotBreak(lbl_start_lotnum.Text))
            {
                if (lotRepository.Findstatus(ing))
                {
                    string Check = lbl_start_check.Text;
                    if (Check == "O")
                    {
                        string lotbarcode = lbl_start_lotnum.Text;
                        string processname = cmb_process.Text;
                        long processid = processRepository.GetProcessId(processname);
                        long lotid = lotRepository.FindLotPkByBarcode(lotbarcode);

                        mainForm.serialPort.WriteLine($"$Run,{processname},{lotid}");
                        MessageBox.Show("LOT이 실행되었습니다");
                        lbl_start_check.Text = "";
                    }
                    else MessageBox.Show("이 Lot은 실행할 수 없습니다");
                }
                else MessageBox.Show("이 공정에는 이미 다른 lot이 실행중입니다");
            }
            else MessageBox.Show("이 LOT은 검사를 통과하지 못했습니다!");

        }


        private void cmb_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status_start = cmb_process.Text; // 내가 고른 콤보박스 공정
            string status = lbl_start_status.Text;  // 현재 공정

            if (status == "created" && status_start == "Mix")
                lbl_start_check.Text = "O";
            else if (status == "MixEnd" && status_start == "Shape")
                lbl_start_check.Text = "O";
            else if (status == "ShapeEnd" && status_start == "Steam")
                lbl_start_check.Text = "O";
            else if (status == "SteamEnd" && status_start == "Fry")
                lbl_start_check.Text = "O";
            else if (status == "FryEnd" && status_start == "Freeze")
                lbl_start_check.Text = "O";
            else if (status == "FreezeEnd" && status_start == "Pack")
                lbl_start_check.Text = "O";
            else lbl_start_check.Text = "X";

        }
        private async void delete_btn_Click(object sender, EventArgs e)
        {
            if (dgv_lot.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_lot.SelectedRows[0].Index;
                long lotId = Convert.ToInt64(dgv_lot.Rows[selectedIndex].Cells["Lot_Id"].Value);

                // 선택된 항목을 삭제하는 로직 (여기에서는 lotId를 사용하여 삭제)
                await lotRepository.deleteLotAsync(lotId);

                // 삭제 후 데이터그리드뷰를 다시 로드하여 업데이트합니다.
                LoadItems("", 0);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.");
            }
            LoadItems("", 0);
        }

        private async void btnhistory_Click(object sender, EventArgs e)
        {
            string lot_barcode;
            lot_barcode = tbox_history.Text;
            var lothistoy = await lothistoryRepository.GetByBarcode(lot_barcode);
            dgv_history1.Rows.Clear();
            dgv_history1.Refresh();
            int i = 0;
            foreach (var Lot in lothistoy)
            {
                dgv_history1.Rows.Add();  // 새로운 row 추가
                string CheckName = "";
                if (Lot.CheckId == 1) { CheckName = "용량검사"; }
                else if (Lot.CheckId == 2) { CheckName = "온도검사"; }
                else if (Lot.CheckId == 3) { CheckName = "출입검사"; }
                dgv_history1.Rows[i].Cells["process_id"].Value = Lot.Process.Process_name;
                dgv_history1.Rows[i].Cells["history_check"].Value = CheckName;
                dgv_history1.Rows[i].Cells["Check_result"].Value = Lot.CheckResult;
                dgv_history1.Rows[i].Cells["Lotdate"].Value = Lot.LotHistory_Date;
                dgv_history1.Rows[i].Cells["lothistory_status"].Value = Lot.LotHistory_status;
                i++;
            }

        }
    }
}
