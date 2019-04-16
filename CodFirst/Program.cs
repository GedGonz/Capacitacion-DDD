using CodFirst.Context;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var con=new CFContext())
            //{
            //    var Lista = con.Persona.ToList();
            //    foreach (var obj in Lista)
            //    {
            //        Console.WriteLine(obj.Nombre);
            //        Console.ReadLine();
            //    }
            //}

            var tagdireccion = "//html/body/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/span/a";
            string html = @"<html><body><table width='100%' height='100%' border='0' cellpadding='0' cellspacing='0'><table width='100%' height='100%' border='0' cellpadding='0' cellspacing='0'><tbody><tr><td valign='top'><table width='90%' border='0' align='center' cellpadding='0' cellspacing='0'><tbody><tr><td><div align='center'><table width='100%' border='0' align='center' cellpadding='0' cellspacing='0' ><tbody><tr style='height: 10px;'><td ></td><td ></td><td ></td></tr><tr><td ></td><td width='100%' align='center' style='font-family:Arial; font-weight: bold;' >DIRECCIÓN GENERAL DE INGRESOS <br>(DGI)</td></tr><tr style='height: 10px;'><td></td><td></td><td></td></tr><tr style='border-bottom: 1px solid #d6d4d4;'></tr></tbody></table><br/><br/></div></td></tr><tr><td><table width='100%'  align='center' cellpadding='0' cellspacing='0'><tbody><tr><td></td><td colspan='4' align='justify'><br><span style='font-family:Arial;'><b>Señor: </b>MINISTERIO DE HACIENDA Y CREDITO PUBLICO                                        </span><br/><span style='font-family:Arial;'><b>Ruc: </b>J1330000002279</span><br/><span style='font-family:Arial;'><b>Renta: </b>RENTA VIRTUAL ENTE GUBERNAMENTAL</span><br/><span style='font-family:Arial;'><b>Período evaluado: </b>01/2019</span><br/><span style='font-family:Arial;color:black !important;'><b>Fecha y Hora: </b>17 febrero 2019 05:33:11 AM</span> <br/><br/><span style='font-family:Arial;'><b>Estimado Contribuyente:</b></span> <br><br><span align='justify' style='font-family:Arial;color:black !important;'>Nuevamente le informamos que algunos números RUC/cédula de la planilla de retenciones del mes de enero 2019, se encuentran inexactos, favor verificar y corregir la planilla. 
                            <br/><br/>Recuerde que se configura una contravención tributaria, la omisión dolosa o fraudulenta en las declaraciones que deben ser presentadas para efectos fiscales o en los documentos para su respaldo, de acuerdo al numeral 8 del arto. 137 de la Ley No. 562, Código Tributario de la República de Nicaragua (CTr).<br/><br/>
                            A la fecha el 99.54%, de los números  RUC informados son válidos, por lo que le invitamos a efectuar las modificaciones correspondientes.</span><br/><span style='font-family:Arial;'><br/>Favor hacer clic en <a href='https://correccionplanilla.dgi.gob.ni/FormularioCorreccion.aspx?var=8F0OaeOb0b/wxgjqIbTXsY6ZDb2tQR+QHDxHEmC2gPE=,AOez5p7zWxLOJpukXiCpzoutV/m7IOb5skPvwH8oahKPSuF4miB3TVkplV9sP9XHJw==,HbyPiQySlfB+VAWrSj70Bw=='>Link Corrección</a> , donde deberá digitar los RUC correctos</span><br/><br/><br/><br/><b style='font-family:Arial;'>Departamento de fiscalización - Renta RENTA VIRTUAL ENTE GUBERNAMENTAL</b><br/><br/></p></td></tr></tbody></table></td></tr><tr><td></br></br><table width='100%' border='0' align='center' cellpadding='0' cellspacing='0' ><tbody><tr style='height: 1px;'><td ></td><td ></td><td ></td> </tr></tbody></table></table></td></tr></tbody></table></td></tr></tbody></table></td></tr><br/><br/><br/><br/><br/></body></html>";
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            //HtmlNode specificNode = doc.GetElementbyId("nodeId");
            //HtmlNodeCollection nodesMatchingXPath = doc.DocumentNode.SelectNodes("x/path/nodes");

            string name = doc.DocumentNode.SelectNodes(tagdireccion).LastOrDefault().Attributes["href"].Value;
        }
    }
}
