﻿using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero:"123456", modelo: "Modelo 1" , imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone (numero:"123456", modelo: "Modelo 1" , imei: "1111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");