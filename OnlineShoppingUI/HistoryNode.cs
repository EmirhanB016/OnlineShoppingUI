using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingUI
{
    internal class HistoryNode
    {
        // Kullanıcının yaptığı işlem (örnek: "Ürün Görüntülendi")
        public string Action { get; set; }

        // Sonraki düğümün adresi (Bağlı liste için kritik!)
        public HistoryNode Next { get; set; }
        public DateTime Timestamp { get; set; }

        // Constructor: Yeni bir düğüm oluştururken action'ı zorunlu kılıyoruz
        public HistoryNode(string action)
        {
            Action = action;
            Timestamp = DateTime.Now;
            Next = null; // Başlangıçta sonraki düğüm yok
        }
    }
}
