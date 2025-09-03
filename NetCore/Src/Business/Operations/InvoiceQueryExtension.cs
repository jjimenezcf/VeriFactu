using VeriFactu.Xml.Factu.Consulta.Respuesta;

namespace VeriFactu.Net.Core.Src.Business.Operations
{
    public static class InvoiceQueryExtension
    {
        public static string GetHuellaFromQueryAeatResponse(this RespuestaConsultaFactuSistemaFacturacion queryAeatResponse, string invoiceNumber)
        {
            if (queryAeatResponse.RegistroRespuestaConsultaFactuSistemaFacturacion != null)
                foreach (var registro in queryAeatResponse.RegistroRespuestaConsultaFactuSistemaFacturacion)
                    if (registro.IDFactura.NumSerieFactura == invoiceNumber)
                        return registro.DatosRegistroFacturacion.Huella;
            return null;
        }
    }
}
