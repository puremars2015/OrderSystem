//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopcartCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class sale
    {
        public int rowid { get; set; }
        public int customer_rowid { get; set; }
        public Nullable<System.DateTime> order_time { get; set; }
        public bool is_delete { get; set; }
        public bool is_order_complete { get; set; }
    }
}