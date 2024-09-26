using System;
using System.Collections.Generic;

public abstract class Hewan
{
    public required string nama { get; set; }
    public int umur { get; set; }

    public abstract string Suara();
    public virtual string InfoHewan()
    {
        return $"Nama: {nama}, Umur: {umur}, Suara: {Suara()}";
    }
}

public class Mamalia : Hewan
{
    public int jumlahKaki { get; set; }

    public override string Suara()
    {
        return "Suara Mamalia";
    }
}

public class Reptil : Hewan
{
    public double panjangTubuh { get; set; }

    public override string Suara()
    {
        return "Suara Reptil";
    }
}

public class Singa : Mamalia
{
    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum!");
    }

    public override string Suara()
    {
        return "Aummm";
    }
}

public class Gajah : Mamalia
{
    public override string Suara()
    {
        return "Trumpet";
    }
}

public class Ular : Reptil
{
    public void Merayap()
    {
        Console.WriteLine("Ular merayap");
    }

    public override string Suara()
    {
        return "Sssh";
    }
}

public class Buaya : Reptil
{
    public override string Suara()
    {
        return "Klok";
    }
}

public class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa { nama = "singa", umur = 5, jumlahKaki = 4 };
        Gajah gajah = new Gajah { nama = "gajah", umur = 10, jumlahKaki = 4 };
        Ular ular = new Ular { nama = "ular", umur = 3, panjangTubuh = 2.5 };
        Buaya buaya = new Buaya { nama = "buaya", umur = 7, panjangTubuh = 4.0 };

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        singa.Mengaum();
        ular.Merayap();
    }
}
