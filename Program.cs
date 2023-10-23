using Desafio_POO.Models;

Iphone iphone = new("6799787787", "123", "Iphone 12", 128);
Nokia nokia = new("6799787787", "123", "Tijolão", 12);

nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigação();
nokia.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigação();
iphone.Ligar();