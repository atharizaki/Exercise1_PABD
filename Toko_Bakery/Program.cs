using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Toko_Bakery
{
    class Program
    {
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-3O1VMEB\\ZAKI;database=toko_Bakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand(
                    "insert into kue(Id_kue, Nama_kue, Jenis_kue, Harga_kue) values('k001', 'bolu kukus', 'kue kering', '2000')" +
                    "insert into kue(Id_kue, Nama_kue, Jenis_kue, Harga_kue) values('k002', 'bika ambon', 'kue kering', '3000')" +
                    "insert into kue(Id_kue, Nama_kue, Jenis_kue, Harga_kue) values('k003', 'dadar gulung', 'kue kering', '1000')" +
                    "insert into kue(Id_kue, Nama_kue, Jenis_kue, Harga_kue) values('k004', 'lapis legit', 'kue basah', '5000')" +
                    "insert into kue(Id_kue, Nama_kue, Jenis_kue, Harga_kue) values('k005', 'onde-onde', 'kue basah', '10000')" +
                    "insert into kasir(id_kasir, Nama_kasir, Alamat, No_hp) values('ksr001', 'fahrizal', 'yogyakarta', '087780976875')" +
                    "insert into kasir(id_kasir, Nama_kasir, Alamat, No_hp) values('ksr002', 'joko', 'batam', '089508081212')" +
                    "insert into kasir(id_kasir, Nama_kasir, Alamat, No_hp) values('ksr003', 'adam', 'bali', '085209091212')" +
                    "insert into kasir(id_kasir, Nama_kasir, Alamat, No_hp) values('ksr004', 'rangga', 'surabaya', '081280803232')" +
                    "insert into kasir(id_kasir, Nama_kasir, Alamat, No_hp) values('ksr005', 'rozi', 'kalimantan', '087823231212')" +
                    "insert into pembeli(Id_pembeli, Nama_pembeli, Jenis_kelamin, Alamat, Tanggal_lahir, No_hp) values('pb001', 'ayom', 'L', 'Yogyakarta', '01-21-2002', '081220203131')" +
                    "insert into pembeli(Id_pembeli, Nama_pembeli, Jenis_kelamin, Alamat, Tanggal_lahir, No_hp) values('pb002', 'dirman', 'L', 'gorontalo', '03-29-2003', '089090902121')" +
                    "insert into pembeli(Id_pembeli, Nama_pembeli, Jenis_kelamin, Alamat, Tanggal_lahir, No_hp) values('pb003', 'wati', 'P', 'papua', '10-17-2001', '085232320909')" +
                    "insert into pembeli(Id_pembeli, Nama_pembeli, Jenis_kelamin, Alamat, Tanggal_lahir, No_hp) values('pb004', 'fitri', 'P', 'bandung', '12-30-2004', '087860609090')" +
                    "insert into pembeli(Id_pembeli, Nama_pembeli, Jenis_kelamin, Alamat, Tanggal_lahir, No_hp) values('pb005', 'riri', 'P', 'sulawesi', '05-20-2000', '083145450909')" +
                    "insert into pembelian(Id_pembelian, Id_kue, Id_pembeli, Nama_pembeli, Nama_kue, Harga_kue, Qty) values('pbl001', 'k001', 'pb001', 'ayom', 'bolu kukus', '2000', '2')" +
                    "insert into pembelian(Id_pembelian, Id_kue, Id_pembeli, Nama_pembeli, Nama_kue, Harga_kue, Qty) values('pbl002', 'k002', 'pb002', 'dirman', 'bika ambon', '3000', '3')" +
                    "insert into pembelian(Id_pembelian, Id_kue, Id_pembeli, Nama_pembeli, Nama_kue, Harga_kue, Qty) values('pbl003', 'k003', 'pb003', 'wati', 'dadar gulung', '1000', '5')" +
                    "insert into pembelian(Id_pembelian, Id_kue, Id_pembeli, Nama_pembeli, Nama_kue, Harga_kue, Qty) values('pbl004', 'k004', 'pb004', 'fitri', 'lapis legit', '5000', '5')" +
                    "insert into pembelian(Id_pembelian, Id_kue, Id_pembeli, Nama_pembeli, Nama_kue, Harga_kue, Qty) values('pbl005', 'k005', 'pb005', 'riri', 'onde-onde', '10000', '7')" +
                    "insert into transaksi(Id_transaksi, Id_pembelian, Id_pembeli, id_kasir, Nama_pembeli, Nama_kasir, Qty, Total_harga, Tanggal_transaksi, Harga_kue) values('trx001', 'pbl001', 'pb001', 'ksr001', 'ayom', 'fahrizal', '2', 4000, '02-27-2021', '2000')" +
                    "insert into transaksi(Id_transaksi, Id_pembelian, Id_pembeli, id_kasir, Nama_pembeli, Nama_kasir, Qty, Total_harga, Tanggal_transaksi, Harga_kue) values('trx002', 'pbl002', 'pb002', 'ksr002', 'dirman', 'joko', '3', 9000, '03-22-2021', '3000')" +
                    "insert into transaksi(Id_transaksi, Id_pembelian, Id_pembeli, id_kasir, Nama_pembeli, Nama_kasir, Qty, Total_harga, Tanggal_transaksi, Harga_kue) values('trx003', 'pbl003', 'pb003', 'ksr003', 'wati', 'adam', '5', 5000, '04-23-2021', '1000')" +
                    "insert into transaksi(Id_transaksi, Id_pembelian, Id_pembeli, id_kasir, Nama_pembeli, Nama_kasir, Qty, Total_harga, Tanggal_transaksi, Harga_kue) values('trx004', 'pbl004', 'pb004', 'ksr004', 'fitri', 'rangga', '5', 25000, '05-24-2021', '5000')" +
                    "insert into transaksi(Id_transaksi, Id_pembelian, Id_pembeli, id_kasir, Nama_pembeli, Nama_kasir, Qty, Total_harga, Tanggal_transaksi, Harga_kue) values('trx005', 'pbl005', 'pb005', 'ksr005', 'riri', 'rozi', '7', 70000, '06-25-2021', '10000')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
    }
}
