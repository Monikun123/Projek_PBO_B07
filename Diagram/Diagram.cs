using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Projek_PBO_B07.Model;

/*KODE PROGRAM SKEMA DIAGRAM
Table pengguna {
  ID_pengguna string [not null, primary key, increment]
nama string[not null]
email string [not null]
password string[not null]
role enum [not null]
}

Table nama_buah
{
    ID_nama_buah string [not null, primary key, increment]
    ID_jenis_buah string [not null, increment]
    gambar varchar [not null]
    nama_buah string [not null]
    harga integer [not null]
}

Table jenis_buah
{
    ID_jenis_buah string [not null, primary key, increment]
    jenis_buah string [not null]
}

Table riwayat
{
    ID_riwayat string [not null, primary key, increment]
    jumlah_keluar integer [not null]
    buah_busuk integer [not null]
    buah_terjual integer [not null]
    tanggal_transaksi date [not null]
}

Table transaksi
{
    ID_transaksi string [not null, primary key, increment]
    ID_produk string [not null, increment]
    ID_riwayat string [not null, increment]
}

Table produk
{
    ID_produk string [not null, primary key, increment]
    ID_promosi string [not null, increment]
    ID_pengguna string [not null, increment]
    ID_nama_buah string [not null, increment]
    tanggal_masuk date [not null]
    tanggal_expired date [not null]
    stok integer [not null]
}

Table promosi
{
    ID_promosi string [not null, primary key, increment]
    diskon integer [not null]
}


Ref: nama_buah.ID_jenis_buah > jenis_buah.ID_jenis_buah

Ref: riwayat.ID_riwayat<transaksi.ID_riwayat

Ref: produk.ID_produk<transaksi.ID_produk

Ref: produk.ID_nama_buah> nama_buah.ID_nama_buah

Ref: promosi.ID_promosi<produk.ID_promosi

Ref: pengguna.ID_pengguna<produk.ID_pengguna*/