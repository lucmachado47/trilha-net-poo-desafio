using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99556677", modelo: "Tijolão", imei: "112233", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "99665544", modelo: "15 Pro", imei: "223311", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
