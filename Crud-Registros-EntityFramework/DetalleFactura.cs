//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crud_Registros_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int CodDetalle { get; set; }
        public int CodFactura { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public int VlrTotal { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
