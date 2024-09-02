using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MasterSenerII.Classes
{
    public class Utilidades
    {
        private Excel.Application app = new Excel.Application();
        private string usu, sen;
        // construtor da classe
        public Utilidades(string usuario, string senha)
        {
            this.usu = usuario;
            this.sen = senha;
        }
        public Utilidades()
        {

        }

        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }


        public string InputTipoLM()
        {
            string Prompt = "Informe o tipo para LM\nEx: ATERRAMENTO\nEx: ITENS MODELADOS\nEx: BANDEJAMENTO";
            string Titulo = "Digite o item da LM";
            string respostaPadrao = "ATERRAMENTO";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputCodigo()
        {
            string Prompt = "Informe o Documento para pesquisa";
            string Titulo = "Digite o Documento";
            string respostaPadrao = "";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputNumerica()
        {
            string Prompt = "Informe a numeração \nEx: 0021";
            string Titulo = "Digite numeração";
            string respostaPadrao = "Todos";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputTexto()
        {
            string Prompt = "Informe parte do texto \nEx: ELETRODUTO";
            string Titulo = "Digite Texto para busca";
            string respostaPadrao = "Todos";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputTipo(string texto)
        {
            string Prompt = "Emitir planilha PURCHASE, clique <OK>\n\nEmitir planilha ESTIMATED, clique <CANCELAR>\n\nEx: ESTIMATED ou PURCHASE";
            string Titulo = "O que deseja emitir";
            string respostaPadrao = texto;

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputRM()
        {
            string Prompt = "Informe a RM \nEx: RM-0021";
            string Titulo = "Digite a RM";
            string respostaPadrao = "RM-";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string InputDisc()
        {
            string Prompt = "Informe a Disciplina \nEx: TUB, ELE, CIN, MCA, SEG, ICO, ARQ";
            string Titulo = "Digite Disciplina";
            string respostaPadrao = "Todos";

            return Interaction.InputBox(Prompt, Titulo, respostaPadrao).ToUpper();
        }

        public string DevolveUnidadeBom(MySqlDataReader reader, int n)
        {
            if (TrataNuloRegisDB(reader, 1) == "TUBI")
                return "M";
            else
                return "EA";

        }

        public Boolean VerificaCamposExcel(string linha, string mto)
        {
            string[] cabecalhoExcelTUB = new string[28];
            string[] cabecalhoExcelELE = new string[15];
            string[] cabecalhoExcelPLAN = new string[60];
            string[] cabecalhoExcelBOM = new string[25];
            string[] linhaSeparadaBOM = linha.Split(';');
            string[] linhaSeparadaTUB = linha.Split(';');
            string[] linhaSeparadaELE = linha.Split('"');
            string[] linhaSeparadaPLAN = linha.Split(';');

            if (mto == "MTO_TUB")
            {
                if (linha != null)
                {

                    cabecalhoExcelTUB[0] = "LINHA";
                    cabecalhoExcelTUB[1] = "TIPO";
                    cabecalhoExcelTUB[2] = "COD_PDMS";
                    cabecalhoExcelTUB[3] = "DESCRIÇÃO_PT";
                    cabecalhoExcelTUB[4] = "DESCRIÇÃO_EN";
                    cabecalhoExcelTUB[5] = "DN1";
                    cabecalhoExcelTUB[6] = "DN2";
                    cabecalhoExcelTUB[7] = "DN3";
                    cabecalhoExcelTUB[8] = "CORTES";
                    cabecalhoExcelTUB[9] = "QUANT";
                    cabecalhoExcelTUB[10] = "PESO_COMP";
                    cabecalhoExcelTUB[11] = "PESO_TUBO";
                    cabecalhoExcelTUB[12] = "COD_CLIENTE";
                    cabecalhoExcelTUB[13] = "SITE";
                    cabecalhoExcelTUB[14] = "Sched";
                    cabecalhoExcelTUB[15] = "Zone";
                    cabecalhoExcelTUB[16] = "Spec";
                    cabecalhoExcelTUB[17] = "MTOC";
                    cabecalhoExcelTUB[18] = "ISOMÉTRICO";
                    cabecalhoExcelTUB[19] = "RM";
                    cabecalhoExcelTUB[20] = "GRUPO";
                    cabecalhoExcelTUB[21] = "NCM";
                    cabecalhoExcelTUB[22] = "DESCR_PT";
                    cabecalhoExcelTUB[23] = "DESCR_EN";
                    cabecalhoExcelTUB[24] = "SPEC-PIPE";
                    cabecalhoExcelTUB[25] = "AREA-PIPE";
                    cabecalhoExcelTUB[26] = "COMPR-BEND";
                    cabecalhoExcelTUB[27] = "AREA-COMP";

                    for (int i = 0; i < cabecalhoExcelTUB.Length; i++)
                    {
                        if (linhaSeparadaTUB[i].ToUpper() != cabecalhoExcelTUB[i].ToUpper())
                        {
                            return false;
                        }
                    }
                }

            }
            else if (mto == "MTO_ELE")
            {
                if (linha != null)
                {

                    cabecalhoExcelELE[0] = "";
                    cabecalhoExcelELE[1] = "Família e tipo";
                    cabecalhoExcelELE[2] = "\t";
                    cabecalhoExcelELE[3] = "Dimensões";
                    cabecalhoExcelELE[4] = "\t";
                    cabecalhoExcelELE[5] = "Codigo_CGA";
                    cabecalhoExcelELE[6] = "\t";
                    cabecalhoExcelELE[7] = "Unidade";
                    cabecalhoExcelELE[8] = "\t";
                    cabecalhoExcelELE[9] = "Disciplina_SNR";
                    cabecalhoExcelELE[10] = "\t";
                    cabecalhoExcelELE[11] = "Número_RM_SNR";
                    cabecalhoExcelELE[12] = "\t";
                    cabecalhoExcelELE[13] = "DOCUMENTO_CGA";
                    cabecalhoExcelELE[14] = "";

                    for (int i = 0; i < linhaSeparadaELE.Length; i++)
                    {
                        if (linhaSeparadaELE[i].ToUpper() != cabecalhoExcelELE[i].ToUpper())
                        {
                            return false;
                        }
                    }
                }

            }
            else if (mto == "SENDOC_FORN")
            {

                if (linha != null)
                {
                    cabecalhoExcelPLAN[0] = "ID";
                    cabecalhoExcelPLAN[1] = "Doc.";
                    cabecalhoExcelPLAN[2] = "Orden de Compra";
                    cabecalhoExcelPLAN[3] = "Tipo";
                    cabecalhoExcelPLAN[4] = "Título";
                    cabecalhoExcelPLAN[5] = "Rev.Sist.Rev.Actual";
                    cabecalhoExcelPLAN[6] = "Rev.Proy.Área";
                    cabecalhoExcelPLAN[7] = "Disciplina";
                    cabecalhoExcelPLAN[8] = "Especialidad";
                    cabecalhoExcelPLAN[9] = "Obj.Emis.";
                    cabecalhoExcelPLAN[10] = "F.Emis.Prev.";
                    cabecalhoExcelPLAN[11] = "Situación";
                    cabecalhoExcelPLAN[12] = "Crítico";
                    cabecalhoExcelPLAN[13] = "Penalizable";
                    cabecalhoExcelPLAN[14] = "Acc.Cliente";
                    cabecalhoExcelPLAN[15] = "Entreg.Cliente";
                    cabecalhoExcelPLAN[16] = "Cod.Aux.";
                    cabecalhoExcelPLAN[17] = "Rev.Aux.";
                    cabecalhoExcelPLAN[18] = "Observaciones";
                    cabecalhoExcelPLAN[19] = "Avance";
                    cabecalhoExcelPLAN[20] = "Peso";
                    cabecalhoExcelPLAN[21] = "Cod.Vendedor";
                    cabecalhoExcelPLAN[22] = "Usuario Vend";
                    cabecalhoExcelPLAN[23] = "Revisor";
                    cabecalhoExcelPLAN[24] = "Clasif.";
                    cabecalhoExcelPLAN[25] = "Propósito";
                    cabecalhoExcelPLAN[26] = "F.Contr VSC";
                    cabecalhoExcelPLAN[27] = "PF";
                    cabecalhoExcelPLAN[28] = "Paso.Actual";
                    cabecalhoExcelPLAN[29] = "F.Paso.Actual";
                    cabecalhoExcelPLAN[30] = "Coment.";
                    cabecalhoExcelPLAN[31] = "Resp.Anterior";
                    cabecalhoExcelPLAN[32] = "Num.Arch.";
                    cabecalhoExcelPLAN[33] = "Fichero / s";
                    cabecalhoExcelPLAN[34] = "F.Inicio Real";
                    cabecalhoExcelPLAN[35] = "F.Recepción.DV";
                    cabecalhoExcelPLAN[36] = "F.Rev.RTS";
                    cabecalhoExcelPLAN[37] = "F.Fin";
                    cabecalhoExcelPLAN[38] = "IRD";
                    cabecalhoExcelPLAN[39] = "F.Calificación";
                    cabecalhoExcelPLAN[40] = "Delay";

                    for (int i = 0; i < 41; i++)
                    {
                        if (cabecalhoExcelPLAN[i].Trim().Length > 0)
                        {
                            if (linhaSeparadaPLAN[i].ToUpper() != cabecalhoExcelPLAN[i].ToUpper())
                            {
                                return false;
                            }

                        }
                    }
                }

            }
            else if (mto == "SENDOC_ENG")
            {

                if (linha != null)
                {
                    cabecalhoExcelPLAN[0] = "ID";
                    cabecalhoExcelPLAN[1] = "Doc.";
                    cabecalhoExcelPLAN[2] = "Tipo";
                    cabecalhoExcelPLAN[3] = "Título";
                    cabecalhoExcelPLAN[4] = "Rev.Sist.";
                    cabecalhoExcelPLAN[5] = "Rev.Actual";
                    cabecalhoExcelPLAN[6] = "Rev.Proy.";
                    cabecalhoExcelPLAN[7] = "Área/Zona";
                    cabecalhoExcelPLAN[8] = "Disciplina";
                    cabecalhoExcelPLAN[9] = "Especialidad";
                    cabecalhoExcelPLAN[10] = "Obj.Emis.";
                    cabecalhoExcelPLAN[11] = "F.Emis.Prev.";
                    cabecalhoExcelPLAN[12] = "Situación";
                    cabecalhoExcelPLAN[13] = "Crítico";
                    cabecalhoExcelPLAN[14] = "Penalizable";
                    cabecalhoExcelPLAN[15] = "Acc.Cliente";
                    cabecalhoExcelPLAN[16] = "Entreg.Cliente";
                    cabecalhoExcelPLAN[17] = "Cod.Aux.";
                    cabecalhoExcelPLAN[18] = "Rev.Aux.";
                    cabecalhoExcelPLAN[19] = "Observaciones";
                    cabecalhoExcelPLAN[20] = "Company";
                    cabecalhoExcelPLAN[21] = "Replanning date";
                    cabecalhoExcelPLAN[22] = "Cost Center";
                    cabecalhoExcelPLAN[23] = "Cod.Aux.2";
                    cabecalhoExcelPLAN[24] = "Pasta Nivel 1";
                    cabecalhoExcelPLAN[25] = "Pasta Nivel 2";
                    cabecalhoExcelPLAN[26] = "Pasta Nivel 3";
                    cabecalhoExcelPLAN[27] = "Cost Unit";
                    cabecalhoExcelPLAN[28] = "EAP_1";
                    cabecalhoExcelPLAN[29] = "EAP_2";
                    cabecalhoExcelPLAN[30] = "Tipo de documento";
                    cabecalhoExcelPLAN[31] = "PF";
                    cabecalhoExcelPLAN[32] = "Paso.Actual";
                    cabecalhoExcelPLAN[33] = "F.Paso.Actual";
                    cabecalhoExcelPLAN[34] = "Coment.";
                    cabecalhoExcelPLAN[35] = "Resp.Anterior";
                    cabecalhoExcelPLAN[36] = "Num.Arch.";
                    cabecalhoExcelPLAN[37] = "Fichero/s";
                    cabecalhoExcelPLAN[38] = "F.Real.Inicio";
                    cabecalhoExcelPLAN[39] = "F.Fin.IRD";
                    cabecalhoExcelPLAN[40] = "F.Fin.Edic.Int.";
                    cabecalhoExcelPLAN[41] = "F.Lib.1";
                    cabecalhoExcelPLAN[42] = "F.Calific.1";
                    cabecalhoExcelPLAN[43] = "F.Lib.2";
                    cabecalhoExcelPLAN[44] = "F.Calific.2";
                    cabecalhoExcelPLAN[45] = "F.Real.Fin";
                    cabecalhoExcelPLAN[46] = "Delay";
                    cabecalhoExcelPLAN[47] = "HT.Salida.1";
                    cabecalhoExcelPLAN[48] = "F.HTS.1";
                    cabecalhoExcelPLAN[49] = "HT.Entrada.1";
                    cabecalhoExcelPLAN[50] = "F.HTE.1";
                    cabecalhoExcelPLAN[51] = "Sit.HTE.1";
                    cabecalhoExcelPLAN[52] = "HT.Salida.2";
                    cabecalhoExcelPLAN[53] = "F.HTS.2";
                    cabecalhoExcelPLAN[54] = "HT.Entrada.2";
                    cabecalhoExcelPLAN[55] = "F.HTE.2";
                    cabecalhoExcelPLAN[56] = "Sit.HTE.2";

                    for (int i = 0; i < 57; i++)
                    {
                        if (cabecalhoExcelPLAN[i].Trim().Length > 0)
                        {
                            if (linhaSeparadaPLAN[i].ToUpper() != cabecalhoExcelPLAN[i].ToUpper())
                            {
                                return false;
                            }

                        }
                    }
                }

            }
            else if (mto == "INDICE_DOC")
            {

                if (linha != null)
                {
                    cabecalhoExcelPLAN[0] = "ITEM";
                    cabecalhoExcelPLAN[1] = "Nº DOC SENER";
                    cabecalhoExcelPLAN[2] = "Nº CGA/SIE";
                    cabecalhoExcelPLAN[3] = "Nº GNA";
                    cabecalhoExcelPLAN[4] = "DESCRIÇÃO";
                    cabecalhoExcelPLAN[5] = "DISCIPLINA";
                    cabecalhoExcelPLAN[6] = "ÁREA";
                    cabecalhoExcelPLAN[7] = "Estimated Date\nBL";
                    cabecalhoExcelPLAN[8] = "Estimated Date    AFC";
                    cabecalhoExcelPLAN[9] = "Eng. Type";
                    cabecalhoExcelPLAN[10] = "";
                    cabecalhoExcelPLAN[11] = "LANGUAGE";
                    cabecalhoExcelPLAN[12] = "";
                    cabecalhoExcelPLAN[13] = "Document Type";
                    cabecalhoExcelPLAN[14] = "";
                    cabecalhoExcelPLAN[15] = "";
                    cabecalhoExcelPLAN[16] = "";
                    cabecalhoExcelPLAN[17] = "GMS";
                    cabecalhoExcelPLAN[18] = "";
                    cabecalhoExcelPLAN[19] = "Remarks";
                    cabecalhoExcelPLAN[20] = "ISSUED FOR";

                    for (int i = 0; i < 20; i++)
                    {
                        if (cabecalhoExcelPLAN[i].Trim().Length > 0)
                        {
                            if (linhaSeparadaPLAN[i].Trim().ToUpper() != cabecalhoExcelPLAN[i].Trim().ToUpper())
                            {
                                return false;
                            }

                        }
                    }
                }

            }
            else if (mto == "BOM_RM")
            {

                if (linha != null)
                {
                    cabecalhoExcelBOM[0] = "DISCIPLINE";
                    cabecalhoExcelBOM[1] = "AREA";
                    cabecalhoExcelBOM[2] = "SUB_AREA";
                    cabecalhoExcelBOM[3] = "";
                    cabecalhoExcelBOM[4] = "ESPECIFICAÇÃO TÉCNICA";
                    cabecalhoExcelBOM[5] = "ISSUE STATUS";
                    cabecalhoExcelBOM[6] = "POSITION STATUS";
                    cabecalhoExcelBOM[7] = "IDENT";
                    cabecalhoExcelBOM[8] = "TAG NUMBER";
                    cabecalhoExcelBOM[9] = "Descritivo Curto Inglês";
                    cabecalhoExcelBOM[10] = "Descritivo Longo Inglês";
                    cabecalhoExcelBOM[11] = "Descritivo Curto Português";
                    cabecalhoExcelBOM[12] = "Descritivo Longo Português";
                    cabecalhoExcelBOM[13] = "Quantidade";
                    cabecalhoExcelBOM[14] = "Unidade";
                    cabecalhoExcelBOM[15] = "Peso Unitário";
                    cabecalhoExcelBOM[16] = "Grupo de Mercadoria";
                    cabecalhoExcelBOM[17] = "NCM";
                    cabecalhoExcelBOM[18] = "CENTRO_SAP";
                    cabecalhoExcelBOM[19] = "DEPOSITO_SAP";
                    cabecalhoExcelBOM[20] = "PROC_PACK";
                    cabecalhoExcelBOM[21] = "Tipo de Material";
                    cabecalhoExcelBOM[22] = "ROS_DATE";

                    for (int i = 0; i < 23; i++)
                    {
                        if (cabecalhoExcelBOM[i].Trim().Length > 0)
                        {
                            if (linhaSeparadaBOM[i].ToUpper() != cabecalhoExcelBOM[i].ToUpper())
                            {
                                return false;
                            }

                        }
                    }
                }

            }
            else if (mto == "BOM_TEMPLATE")
            {

                if (linha != null)
                {

                    cabecalhoExcelBOM[0] = "PROJECT";
                    cabecalhoExcelBOM[1] = "DISCIPLINE";
                    cabecalhoExcelBOM[2] = "AREA";
                    cabecalhoExcelBOM[3] = "SUB_AREA";
                    cabecalhoExcelBOM[4] = "DOCUMENT";
                    cabecalhoExcelBOM[5] = "ISSUE STATUS";
                    cabecalhoExcelBOM[6] = "POSITION STATUS";
                    cabecalhoExcelBOM[7] = "IDENT";
                    cabecalhoExcelBOM[8] = "TAG NUMBER";
                    cabecalhoExcelBOM[9] = "Descritivo Curto Inglês";
                    cabecalhoExcelBOM[10] = "Descritivo Longo Inglês";
                    cabecalhoExcelBOM[11] = "Descritivo Curto Português";
                    cabecalhoExcelBOM[12] = "Descritivo Longo Português";
                    cabecalhoExcelBOM[13] = "Quantidade";
                    cabecalhoExcelBOM[14] = "Unidade";
                    cabecalhoExcelBOM[15] = "Peso Unitário";

                    for (int i = 0; i < 16; i++)
                    {
                        if (cabecalhoExcelBOM[i].Trim().Length > 0)
                        {
                            if (linhaSeparadaBOM[i].ToUpper() != cabecalhoExcelBOM[i].ToUpper())
                            {
                                return false;
                            }

                        }
                    }
                }

            }

            return true;

        }

        public string AbrirArqExcel()
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Localizar arquivos";
                openFileDialog.InitialDirectory = "c:\\users\\" + usu + "\\Documents";
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;

                }
            }
            return "";

        }

        public List<string> OpenArqExcel()
        {
            List<string> list = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Localizar arquivos";
                openFileDialog.InitialDirectory = "c:\\users\\" + usu + "\\Documents";
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    foreach (String file in openFileDialog.FileNames)
                    {
                        //Get the path of specified file
                        list.Add(file.ToString());
                    }

                }
            }
            return list;

        }

        public List<string> OpenArqPdf()
        {
            List<string> list = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Localizar arquivos";
                openFileDialog.InitialDirectory = "c:\\users\\" + usu + "\\Documents";
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.pdf)|*.pdf";
                openFileDialog.Multiselect = true;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    foreach (String file in openFileDialog.FileNames)
                    {
                        //Get the path of specified file
                        list.Add(openFileDialog.SafeFileName);
                        list.Add(file.ToString());
                    }

                }
            }
            return list;

        }

        public List<string> AbrirArqTexto()
        {

            List<string> list = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Localizar arquivos";
                openFileDialog.InitialDirectory = "c:\\users\\" + usu + "\\Documents";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    foreach (String file in openFileDialog.FileNames)
                    {
                        //Get the path of specified file
                        list.Add(file.ToString());
                    }

                }
            }
            return list;

        }

        public string SalvaArqExcel(string nameFile, Excel.Application app)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.FileName = nameFile;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Save as";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);

                //codigo para escrever o stream
                app.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                app.ActiveWorkbook.Saved = true;
                return fileInfo.DirectoryName.ToString();
            }
            return "";

        }

        public void SalvaArqExcelSemDialog(string nameFile, Excel.Application app)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.FileName = nameFile;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Save as";

            //codigo para escrever o stream
            app.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName + ".xlsx");
            app.ActiveWorkbook.Saved = true;


        }

        public string TrataNuloRegisDB(MySqlDataReader reader, int n)
        {
            string aux = "";

            if (!reader.IsDBNull(n))
            {

                try
                {
                    if (reader.GetDataTypeName(n).Equals("DATETIME"))
                        aux = reader.GetDateTime(n).ToString();
                    else if (reader.GetDataTypeName(n).Equals("VARCHAR"))
                        aux = reader.GetString(n).ToString();
                    else if (reader.GetDataTypeName(n).Equals("INT"))
                        aux = reader.GetInt64(n).ToString();
                    else if (reader.GetDataTypeName(n).Equals("DOUBLE"))
                        aux = reader.GetDouble(n).ToString();
                    else if (reader.GetDataTypeName(n).Equals("DECIMAL"))
                        aux = reader.GetDecimal(n).ToString();
                    else if (reader.GetDataTypeName(n).Equals("BIGINT"))
                        aux = reader.GetDecimal(n).ToString();

                    aux = aux.Trim();

                }
                catch (Exception)
                {
                    aux = reader.GetDecimal(n).ToString();
                    if (String.IsNullOrEmpty(aux)) aux = "";
                }
            }

            return aux;
        }

        public string TrataData(string data)
        {
            string ano;
            string mes;
            string dia;

            if (data == null)
            {
                //data = "0000/00/00";
                data = "";

            }
            else if (data.Trim().Length > 0)
            {
                ano = data.Substring(6, 4);
                mes = data.Substring(3, 2);
                dia = data.Substring(0, 2);
                data = ano + "/" + mes + "/" + dia;
            }
            else
            {
                data = "0000/00/00";
                //data = "";
            }

            return data;
        }

        public string TrataNumero(string dado)
        {
            if ((dado == null) || (dado.Trim() == ""))
            {
                return "0";

            }

            return dado;
        }

        public DateTime TrataDataTime(string data)
        {
            DateTime dt = new DateTime();

            if (data == null)
                dt = DateTime.Parse("");

            else if (data == "")
                dt = DateTime.Parse("");

            else if (data.Trim().Length > 0)
                dt = DateTime.Parse(data);


            return dt;
        }

        public string CortaDescritivo(string desc)
        {
            if (desc.Trim() != "")
            {
                if (desc.Trim().Length > 40)
                    return desc.Substring(0, 39);
                else
                    return desc.Trim();
            }
            return "";
        }

        public string RetiraPontoVirgulaTexto(string desc)
        {
            if (desc.Trim() != "")
            {
                if (desc.Trim().Length != 0)
                    return desc.Replace(";", ",");
            }
            return "";
        }

        public string TrataValores(string valor)
        {
            if (valor != null)
            {
                if (valor.Trim() == "")
                    return "0.00";
                else if (valor.Trim() == "0")
                    return "0.00";
                else if (valor.Trim() == "-")
                    return "0.00";
                else
                    return valor.Replace(",", ".");
            }
            return "0.00";

        }

        public string TrataNulo(string texto)
        {
            if (texto != null)
                return texto.Trim().Replace("'", " ");
            return "";
        }

        public string TrataUnset(string texto)
        {
            if (texto == "unset")
                texto = "";
            return texto.Trim();
        }

        public string TrataDn(string texto)
        {
            string aux = "";

            if (texto.Equals("0.1/4"))
                texto = "1/4";
            else if (texto.Equals("0.1/8"))
                texto = "1/8";
            else if (texto.Equals("0.1/2"))
                texto = "1/2";
            else if (texto.Equals("0.3/4"))
                texto = "3/4";
            aux = texto;

            return aux;
        }

        public string RetiraBarra(string texto)
        {
            string aux = "";

            texto = texto.Replace('\"', ' ').Trim();
            texto = texto.Replace('\\', ' ').Trim();

            if ((texto.Trim() != "") && (texto.Trim().Substring(0, 1) == "/"))
                aux = texto.Trim().Substring(1, texto.Trim().Length - 1);


            return aux;
        }

        public string RetiraApostrofo(string texto)
        {
            if (texto == null)
                return "";
            else if (texto.Trim() == "")
                return "";
            else
                return texto.Replace("'", " ");
        }

        public bool VerificaHeaderExcel(Excel.Application napp, Excel.Workbook nwork, Excel.Worksheet nws)
        {

            // campos da planilha Excel 
            string[] colExcel = {   "ID",
                                    "Documento",
                                    "Orden de Compra",
                                    "OC/DV",
                                    "Tipo",
                                    "Título",
                                    "Rev.Sist.",
                                    "Rev.Actual",
                                    "Rev.Proy.",
                                    "Área",
                                    "Disciplina",
                                    "Especialidad",
                                    "Obj.Emis.",
                                    "F.Emis.Prev.",
                                    "Situación",
                                    "Crítico",
                                    "Penalizable",
                                    "Acc.Cliente",
                                    "Entreg.Cliente",
                                    "Cod.Aux.",
                                    "Rev.Aux.",
                                    "Observaciones",
                                    "Avance",
                                    "Peso",
                                    "Cod.Vendedor",
                                    "Usuario Vend",
                                    "Revisor",
                                    "Clasif.",
                                    "Propósito",
                                    "F.Contr VSC",
                                    "PF",
                                    "Paso.Actual",
                                    "F.Paso.Actual",
                                    "Coment.",
                                    "Resp.Anterior",
                                    "Num.Arch.",
                                    "Fichero/s",
                                    "F.Inicio Real",
                                    "F.Recepción.DV",
                                    "F.Rev.RTS",
                                    "F.Fin IRD",
                                    "F.Calificación",
                                    "Delay",
                                    "HT.Entrada.1",
                                    "F.HTE.1",
                                    "HT.Salida.1",
                                    "F.HTS.1",
                                    "Sit.HTS.1",
                                    "HT.Entrada.2",
                                    "F.HTE.2",
                                    "HT.Salida.2",
                                    "F.HTS.2",
                                    "Sit.HTS.2" };

            bool flag = true;
            for (int i = 0; i < colExcel.Length; i++)
            {

                if (TrataNulo(Convert.ToString(nws.Cells[4, i + 1].Value)) != colExcel[i])
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}
