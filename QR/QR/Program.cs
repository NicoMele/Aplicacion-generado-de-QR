using iTextSharp.text;
using iTextSharp.text.pdf;

Document doc = new Document(PageSize.A4);
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string fullPath = Path.Combine(desktopPath, "CodigoQr.pdf");

PdfWriter.GetInstance(doc, new FileStream(fullPath, FileMode.Create));
doc.Open();
doc.Add(new Paragraph("Escanee el código Qr"));
BarcodeQRCode qRCode = new BarcodeQRCode("https://www.youtube.com/watch?v=q1ULJ92aldE&list=PLHCvaq-UcL_Up7l72-rnwbGt_j63geFqd&ab_channel=NoCopyrightSounds", 1000,1000,null);
Image qrCodeImage = qRCode.GetImage();
qrCodeImage.ScaleAbsolute(100, 100);
doc.Add(qrCodeImage);
doc.Close();