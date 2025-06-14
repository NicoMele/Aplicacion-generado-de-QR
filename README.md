# 🧾 QR Code PDF Generator

A **simple yet powerful** C# application using `iTextSharp` that generates a **PDF file with a scannable QR code** pointing to a YouTube video.

---

## ⚙️ Technologies Used

- [.NET / C#](https://dotnet.microsoft.com/)
- [iTextSharp](https://github.com/itext/itextsharp) – A .NET library for PDF creation and manipulation

---

## 📌 What It Does

- Creates a `CodigoQr.pdf` file on your Desktop  
- Adds a title: **"Scan the QR Code"**  
- Embeds a **QR code** linking to this YouTube video:  
  [https://www.youtube.com/watch?v=q1ULJ92aldE](https://www.youtube.com/watch?v=q1ULJ92aldE)

---

## 🧪 How to Use

1. Install `iTextSharp` in your project:

   ```bash
   Install-Package iTextSharp -Version 5.5.13
