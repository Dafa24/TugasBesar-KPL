using static ConsoleApp1.TableDriven;

internal class Program
{
    private static void Main(string[] args)
    {
    
            TabelInventaris inventaris = new TabelInventaris();

            // Menambahkan barang dengan menggunakan enum untuk jenis dan status
            inventaris.TambahBarang("Keyboard", "Keyboard Mechanic", 50, JenisBarang.Elektronik);
            inventaris.TambahBarang("Mouse", "Gaming Mouse", 30, JenisBarang.Elektronik);

        // Contoh penggunaan: Menampilkan barang dengan ID 1
        Barang barang = inventaris.GetBarang(1);
        if (barang != null)
        {
            Console.WriteLine($"Barang ditemukan: {barang.Nama}, Deskripsi: {barang.Deskripsi}, Harga: {barang.Harga}");
        }
        else
        {
            Console.WriteLine("Barang tidak ditemukan.");
        }
    }
    }
