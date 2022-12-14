<h2 style="font-weight: 700; font-size: 2rem">SISTEM PENITIPAN BARANG</h2>

<br>
Project UAS Visual Basic Semester 3

- Agus Setiawan (2107411013)
- Alfares Ariandha Nurdin (2107411020)
- Nibras Alyassar (2107411026)
- Gerry Satria Halim (2107411028)

<hr>
<h2 style="font-weight: 700">Requirement</h2>
<hr>

### Class :

- Database
- User_model
- Locker_model
- Rent_model

### Form :

- Login dan Sign Up
- Form Sewa (menampilkan form dengan textbox rencana sewa (waktu) dan akan tampil biaya sewa total Hanya Input Sewa dan Waktu sewa (dalam jam))
- Form Checkout Barang (Kembali)
- Tambah dan Hapus Loker
- Ganti Status Locker
- Form View Loker, Jenis Loker, dan History Penyewaan
- Tambah, Hapus, dan Update Jenis Loker

### Fitur :

- Dapat Login dan Log Out
- User Adalah Maintainer Locker
- Form Monitor Loker berisi informasi status locker isi atau kosong dan info lain locker
- Form Edit Locker memiliki fungsi mengganti informasi data locker
- Form Ganti Status Locker mengganti Status locker isi atau kosong
- Form Data Sewa berisi data sewa, dan saat data sewa diinput status locker yang dipilih pada data locker akan diganti menjadi isi
- Form Jenis Ukuran berisi data informasi jenis locker dan sub form tambah, ubah, dan hapus untuk memanipulasi data jenis ukuran
- Penghitungan biaya sewa dihitung berdasarkan biaya di data jenis locker dikali lama penyewaan (jam).
  Kelebihan Pinjam pada form penyewaan terjadi saat waktu pengembalian telah melewati waktu rencana pinjam

### Table :

- Users (id, username, email, password)
- Locker : (id, id_ukuran, lokasi, status)
- Jenis_Ukuran : (id, ukuran, biaya)
- Penyewaan (id, id_locker, tanggal_sewa, tanggal_kembali, bayar_sebelum_pinjam, rencana_pinjam, kelebihan pinjam, total_bayar)

<br>

<hr>
<h2 style="font-weight: 700">Unified Modeling Language Diagram</h2>
<hr>

### Use Case Diagram :

<img src="./img/UCD.png" alt="Use Case Diagram">

<hr>

### Class Diagram :

<i>Asosiasi Class Database</i>
<br>
<img src="./img/Database_CD_Asosiasi.jpg" alt="Use Case Diagram">

<br>

<i>Asosiasi Class User_model</i>
<br>
<img src="./img/User_model_CD_Asosiasi.jpg" alt="Use Case Diagram">

<br>

<i>Asosiasi Class Locker_model</i>
<br>
<img src="./img/Locker_model_CD_Asosiasi.png" alt="Use Case Diagram">

<br>

<i>Asosiasi Class Rent_model</i>
<br>
<img src="./img/Rent_model_CD_Asosiasi.jpg" alt="Use Case Diagram">

<br>

<hr>
<h2 style="font-weight: 700">Activity Diagram</h2>
<hr>

<i>Sign Up dan Login</i>
<br>
<img src="./img/Signup_dan_Login_AD.jpg" alt="Activity Diagram">

<br>

<i>Kelola Data Loker</i>
<br>
<img src="./img/Kelola_Data_Loker_AD.jpg" alt="Activity Diagram">

<br>

<i>Sewa Loker</i>
<br>
<img src="./img/Sewa_Loker_AD.jpg" alt="Activity Diagram">

<br>

<i>Pengembalian Loker</i>
<br>
<img src="./img/Pengembalian_Loker_AD.jpg" alt="Activity Diagram">

<br>

<i>Hapus Data Loker</i>
<br>
<img src="./img/Hapus_Data_Sewa_AD.jpg" alt="Activity Diagram">
