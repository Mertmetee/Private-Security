SELECT GNBT.*,OGBT.Adi+' '+OGBT.Soyadi AS AdSoyad FROM
[GuvenlikNoktasiBilgileriTablosu] GNBT
LEFT OUTER JOIN [OzelGuvenlikBilgileriTablosu] OGBT
ON GNBT.GuvenlikSefiSicilNumarasi=OGBT.SicilNumarasi
Where GuvenlikNoktasiAdi LIKE '__ð%'