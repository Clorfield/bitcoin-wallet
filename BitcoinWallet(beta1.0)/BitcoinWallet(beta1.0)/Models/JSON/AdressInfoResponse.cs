using System.Collections.Generic;

namespace BitcoinWallet_beta1._0_.Models.JSON
{
    public class AdressInfoResponse
    {
        public bool success { get; set; }
        public Paging paging { get; set; }
        public IList<Unspent> unspent { get; set; }
    }

    public class Paging
    {
        public IList<string> valid_sort { get; set; }
        public int limit { get; set; }
        public string sort { get; set; }
        public string dir { get; set; }
        public object prev { get; set; }
        public object next { get; set; }
        public object prev_link { get; set; }
        public object next_link { get; set; }
    }

    public class ScriptPubKey
    {
        public string asm { get; set; }
        public string hex { get; set; }
    }

    public class Unspent
    {
        public IList<string> addresses { get; set; }
        public string value { get; set; }
        public int value_int { get; set; }
        public string txid { get; set; }
        public int n { get; set; }
        public ScriptPubKey script_pub_key { get; set; }
        public int req_sigs { get; set; }
        public string type { get; set; }
        public int confirmations { get; set; }
        public int id { get; set; }
    }
}
