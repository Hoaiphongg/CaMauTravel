﻿use CaMauTravel

--Account
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('Admin','21232f297a57a5a743894a0e4a801fc3',2,'Adminstrator',1,'09/09/2000','Can Tho','0939892820','adminstrator@gmail.com')

Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User1','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 1',1,'09/09/2000','Can Tho','0939892820','User1@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User2','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 2',0,'09/09/2000','An Giang','0939892820','User2@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User3','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 3',1,'09/09/2000','Can Tho','0939892820','User3@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User4','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 4',0,'09/09/2000','An Giang','0939892820','User4@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User5','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 5',1,'09/09/2000','Can Tho','0939892820','User5@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User6','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 6',0,'09/09/2000','An Giang','0939892820','User6@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User7','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 7',1,'09/09/2000','Can Tho','0939892820','User7@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User8','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 8',0,'09/09/2000','Ca Mau','0939892820','User8@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User9','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 9',1,'09/09/2000','Can Tho','0939892820','User9@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User10','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 10',0,'09/09/2000','Bac Lieu','0939892820','User10@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User11','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 11',1,'09/09/2000','Ha Noi','0939892820','User11@gmail.com')
Insert into Account([username],[password],[roll],[name],[gender],[birthday],[address],[phone],[email]) values ('User12','e10adc3949ba59abbe56e057f20f883e',1,'Cutomer 12',0,'09/09/2000','Soc Trang','0939892820','User12@gmail.com')

--PlaceType
Insert into PlaceType([Name],[Description],[MetaTitle]) values (N'Di Tích Lịch Sử', N'Di tích lịch sử là công trình xây dựng, địa điểm và các di vật, cổ vật, bảo vật quốc gia thuộc công trình, địa điểm đó có giá trị lịch sử, văn hóa, khoa học. ','di-tich-lich-su')
Insert into PlaceType([Name],[Description],[MetaTitle]) values (N'Rừng', N'Rừng là quần xã sinh vật trong đó cây rừng là thành phần chủ yếu. Nói cách khác, rừng là tập hợp của nhiều cây. Quần xã sinh vật phải có diện tích đủ lớn. Giữa quần xã sinh vật và môi trường, các thành phần trong quần xã sinh vật phải có mối quan hệ mật thiết để đảm bảo khác biệt giữa hoàn cảnh rừng và các hoàn cảnh khác.','rung')
Insert into PlaceType([Name],[Description],[MetaTitle]) values (N'Du Lịch Sinh Thái', N'Du lịch sinh thái là chính là bạn sẽ được hòa mình với thiên nhiên và không khí trong lành của mọi thứ xung quanh. Du lịch sinh thái sẽ đưa bạn đến những nơi tự nhiên còn ít thay đổi để khám phá, tham quan mọi thứ . Và hiện nay ở Việt Nam có khá nhiều khu vực du lịch sinh thái khác nhau ví dụ điển hình là Vịnh Hạ Long','du-lich-sinh-thai')
Insert into PlaceType([Name],[Description],[MetaTitle]) values (N'Chùa', N'Chùa là một công trình kiến trúc phục vụ mục đích tín ngưỡng. Chùa được xây dựng phổ biến ở các nước Nam Á như Ấn Độ, Nepal, Bhutan ,... cùng với một số nước Đông Á và Đông Nam Á như Trung Quốc, Nhật Bản, Việt Nam và thường là nơi thờ Phật. Tại nhiều nơi, chùa có nhiều điểm giống với chùa tháp của Ấn Độ, vốn là nơi cất giữ Xá-lị và chôn cất các vị đại sư, thường có nhiều tháp bao xung quanh.','chua')

--Touris Attraction


Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Chợ Nổi Cà Mau', N'Chợ nổi Cà Mau nằm trên đoạn cuối con sông Gành Hào, cách cầu Gành Hào khoảng hơn 200m ở phường 8, trung tâm thành phố Cà Mau. Đây là nơi tập trung nhiều tàu bè buôn bán chở đầy các loại nông sản và hàng hóa của người dân.Đây là khu chợ người dân địa phương tự họp hàng ngày và hoạt động nhộn nhịp nhất là vào khoảng thời gian từ 2 – 3 giờ sáng. Du khách đến đây sẽ có cơ hội được trải nghiệm chuyến vòng quanh chợ nổi vào sáng sớm.Du khách có thể di chuyển từ bên xe thành phố Cà Mau đến chợ nổi Cà Mau chỉ khoảng 4km. Bạn có thể di chuyển bằng taxi hoặc bằng xe ôm, để thuận tiện hơn cho việc đi lại thì việc lựa chọn tự đi xe máy đến để tự do di chuyển hơn trong việc thăm quan.',3,'cho-noi-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Hòn Đá Bạc Cà Mau', N'Hòn Đá Bạc, cách thành phố Cà Mau khoảng 50 km, cách đất liền khoảng 500 mét, có diện tích 6,34 ha, nằm ở phía tây Bán đảo Cà Mau, thuộc địa phận ấp Kinh Hòn, xã Khánh Bình Tây, huyện Trần Văn Thời.Hòn Đá Bạc bao gồm Hòn Ông Ngộ, Hòn Đá Bạc, Hòn Đá Bạc Lẻ. Đỉnh cao nhất của hòn khoảng 50 mét so với mặt nước biển. Tuy không phải là một hòn đảo lớn nhưng Hòn Đá Bạc rất thuận tiện cho các loại phương tiện khai thác biển vào neo đậu và tránh gió bão. Cùng với Hòn Khoai, Hòn Chuối, Hòn Đá Bạc là một trong những cụm đảo có vị trí chiến lược về kinh tế – quốc phòng – an ninh trên vùng biển - đảo Cà Mau.Trên hòn có một vài ngôi chùa nhỏ như chùa Hang, chùa Tịnh độ. Đặc biệt, trên đỉnh cao nhất của Hòn Đá Bạc là đền thờ Ông Nam Hải - nơi thờ bộ xương cá Ông dài 13m. Ngày 20/5/1995, cá Ông dạt vào khu vực cửa sông Ông Đốc. Khoảng 3 ngày sau, Ông lụy (chết), ngư dân Sông Đốc đem chôn và đến năm 1996 đưa bộ xương về Hòn Đá Bạc để thờ cúng.',3,'hon-da-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Đầm Thị Tường Cà Mau', N'Đầm Thị Tường hay còn gọi Đầm Bà Tường được mệnh danh là “biển hồ giữa đồng bằng”, là điểm đến lý tưởng cho những ai muốn tìm về một nơi bình yên. Sự độc đáo của phong tục tập quán kết hợp với nhiều nét văn hóa của người dân bản địa đã tạo nên một vẻ đẹp hiếm có cho đầm Thị Tường.Đầm Thị Tường nằm trên địa phận 3 huyện: Cái Nước, Trần Văn Thời và Phú Tân, tỉnh Cà Mau. Để đến được vùng sông nước rộng lớn này, du khách từ Cà Mau theo hướng Quốc lộ 1A đến chợ Rau Dừa, rẽ phải qua cầu Cái Bần, rồi chạy theo con đường nông thôn 3m, qua chừng 7km theo địa danh ấp Thị Tường (xã Hòa Mỹ) là đến Đầm Trong. Du khách cũng có thể từ chợ Rau Dừa đi thêm 2km theo Quốc lộ 1A đến Kênh 4 Cống Đá, rẽ phải theo hướng chỉ dẫn về Khu Căn cứ Xẻo Đước, khoảng 8km là đến Đầm Giữa – điểm đến lý thú và đặc sắc nhất Đầm Thị Tường.Đầm Thị Tường được hình thành từ phù sa bồi lắng của sông Mỹ Bình, sông Ông Đốc và nhiều kênh rạch khác.',3,'dam-thi-tuong-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Rừng Ngập Mặn Cà Mau', N'Cách thành phố Cà Mau khoảng 60 km và sau hơn giờ đi bằng tàu cao tốc du khách sẽ được khám phá rừng ngập mặn Cà Mau – khu rừng ngập mặn lớn thứ 2 trên thế giới, sau rừng Amazôn ở Nam Mỹ. Nhìn từ trên cao, rừng ngập mặn Cà Mau như một tấm thảm xanh lơ lửng giữa vòm trời.Giai đoạn từ năm 1961 đến 1971, Mỹ đã sử dụng hàng triệu lít chất độc màu da cam, chất độc màu trắng và chất độc màu xanh lơ để rải xuống rừng ở Cà Mau. Khi còn nắm trong tay quyền lực của một “Đệ nhất phu nhân”, Trần Lệ Xuân câu kết với nhiều tay chân tư sản ở Sài Gòn mở cúp, xây lò, hầm than, khai thác triệt để than củi ở rừng ngập mặn Cà Mau. Tại nhiều nơi ở rừng ngập mặn Cà Mau vẫn còn lưu lại dấu tích lò hầm than của “Đệ nhất phu nhân Trần Lệ Xuân”.Dưới tán tán rừng ngập mặn Cà Mau có nhiều loài động vật quý hiếm như khỉ, voọc, heo rừng, chồn, rái cá, chim, tôm, cá cùng nhiều loại động thực vật phiêu sinh.',3,'rung-ngap-man-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Mũi Cà Mau', N'Mũi Cà Mau hướng về phía tây, thuộc địa phận xóm Mũi, xã Đất Mũi, huyện Ngọc Hiển, tỉnh Cà Mau, cách thành phố Cà Mau hơn 100 km. Bên trái mũi là biển Đông, bên phải là biển Tây, tức Vịnh Thái Lan.Hiện nay nếu xét về mặt địa lý thì mũi Cà Mau không phải là điểm cực Nam trên đất liền của Việt Nam, mà chỉ nằm ở vùng cực Nam của Việt Nam. Điểm cực nam trên đất liền của tỉnh Cà Mau nằm ở xã Viên An, huyện Ngọc Hiển, có độ vĩ 8°30 Bắc. Mũi Cà Mau là điểm cực Tây của tỉnh Cà Mau.Tại đây có hệ sinh thái rừng ngập mặn rất đa dạng và phong phú. Và còn có các công trình như cột mốc toạ độ quốc gia, biểu tượng Mũi Cà Mau.',3,'mui-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Khu Vườn Chim Cà Mau', N'Với khuôn viên rộng, nhiều cây xanh thoáng, mát rượi, Khu tưởng niệm Chủ tịch Hồ Chí Minh ở Cà Mau không chỉ là nơi tưởng nhớ Bác, mà còn là điểm đến tham quan du lịch Cà Mau hấp dẫn du khách gần xa.Với khuôn viên rộng, nhiều cây xanh thoáng, mát rượi, Khu tưởng niệm Chủ tịch Hồ Chí Minh ở Cà Mau không chỉ là nơi tưởng nhớ Bác, mà còn là điểm đến tham quan du lịch Cà Mau hấp dẫn du khách gần xa.Đặc biệt, khu vực này có nhiều cá thể chim, cò,… về từng đàn, lưu trú đông đúc tạo nên một vườn chim độc nhất vô nhị nằm giữa lòng thành phố. Hằng năm, cứ vào dịp Tết, chim chóc lại tụ hội về đây như đã hò hẹn tự bao giờ. Khung cảnh vườn chim trong tiết xuân thật trữ tình, thơ mộng. Chiều chiều, tiếng hót gọi bạn, tiếng đập cánh xôn xao cả khu rừng.',3,'vuon-chim-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Đảo Hòn Khoai Cà Mau', N'Hòn Khoai là tên một cụm đảo nằm ở phía Đông Nam mũi Cà Mau thuộc xã Tân Ân, huyện Ngọc Hiển, tỉnh Cà Mau. Hòn Khoai cách đất liền hơn 6 hải lý (14,6km) có vị trí quan trọng về quốc phòng an ninh. Nơi đây được ví như một trạm tiền tiêu canh giữ vùng trời, vùng biển và dải đất phía Tây Nam của Tổ quốc.Nếu đi tàu từ Rạch Gốc (cửa ngõ của huyện Ngọc Hiển ra biển Đông), thì chỉ sau 3 giờ vượt biển, du khách đã có thể chiêm ngưỡng được Hòn Khoai – một trong những hòn đảo đẹp nhất miền cực nam của Tổ quốcĐảo Hòn Khoai gồm nhiều đảo nhỏ: Hòn Khoai, Hòn Tượng, Hòn Sao, Hòn Đồi Mồi, Hòn Đá Lẻ. Trong đó Hòn Khoai là đảo lớn nhất với diện tích khoảng 4km2 và cũng là hòn đảo cao nhất so mực nước biển là 318m. Xưa kia, địa danh này còn được gọi với nhiều cái tên khác nhau như: Hòn Giáng Hương, Hòn Độc Lập hay đảo Poulop vào thời Pháp.Hòn Khoai là hòn đảo đá, đồi và rừng nguyên sinh còn gần như nguyên vẹn với nhiều loại gỗ quý cùng quần thể động thực vật phong phú, chính điều đó đã làm say lòng biết bao du khách. Theo nghiên cứu mới nhất hệ thực vật ở Hòn Khoai có hơn 1.400 loài gồm cây ăn trái, cây lấy gỗ, cây làm thuốc… Động vật cũng khá phong phú với các loài khỉ, gà rừng, trăn hoa, kỳ đà, sóc bụng trắng… và hơn 20 loài chim qúy.',3,'dau-hon-khoai-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Khu Du Lịch Biển Khai Long Cà Mau', N'Bãi biển Khai Long là một bãi cát giồng uốn lượn dọc bờ biển thuộc ấp Khai Long, xã Đất Mũi, huyện Ngọc Hiển, với diện tích khoảng 230 ha, chiều dài theo bờ biển 3.800 m và cách khu du lịch Mũi Cà Mau 18 km. Đây là bãi biển vẫn còn đậm nét hoang sơ hòa với vẻ đẹp dân dã mộc mạc nơi đất mũi dải đất chữ S này.Cà Mau là vùng đất quanh năm ngặp mặn, nhiễm phèn, đây là điều kiện hình thành hệ thống rừng ngập mặn đặc trưng. Trong danh sách này điển hình có rừng U Minh Hạ, rừng ngập mặn Cà Mau. Diện tích của hai ứng cử này rất lớn, với độ phủ trải rộng vùng vành đai đất liền Cà Mau.Bãi biển Khai Long nằm phía biển Đông trong khu vực hệ sinh thái rừng ngập mặn. Muốn đặt chân lên đây du khách buộc phải đi ca nô hoặc thuyền khoảng một giờ đồng hồ với điểm xuất phát từ Thành phố Cà Mau.Đứng ở bãi Khai Long, du khách có thể phóng tầm mắt ngắm nhìn trọn vẹn hình dáng, vẻ đẹp hoang sơ của cụm đảo Hòn Khoai hùng vĩ.Chính điều này đã tạo nên điểm khác biệt của bãi biển Khai Long. Không đơn thuần là một bãi biển mà còn là hệ sinh thái rừng ngập mặn trù phú',3,'khu-du-lich-bien-khai-long-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Rừng Quốc Gia U Minh Hạ Cà Mau', N'Vườn quốc gia U Minh Hạ với diện tích 8.527,8 ha được thành lập ngày 20/1/2006, thuộc địa giới hành chính 4 xã thuộc 2 huyện Trần Văn Thời và U Minh, tỉnh Cà Mau. Nằm về phía tây tỉnh Cà Mau, cách thành phố Cà Mau không khoảng 25km, mất hơn 30 phút ngồi ô tô, du khách sẽ đến Vườn quốc gia U Minh HạĐặc trưng nổi bật là hệ sinh thái rừng tràm hình thành trong điều kiện ngập nước, úng phèn, trên đất than bùn, là cây tiêu biểu của vùng đồng bằng sông Cửu Long. Vào ngày 26 tháng 5 năm 2009, vườn quốc gia U Minh Hạ được UNESCO công nhận là 1 trong 3 vùng lõi của Khu dự trữ sinh quyển Thế giới Mũi Cà Mau.Hệ thống động thực vật ở đây vô cùng phong phú và đa dạng: có gần 250 loài thực vật 250 loài thực vật, 182 loài chim, 20 loài bò sát sát và lưỡng thê, 40 loài thú và nhiều loài côn trùng khác, trong đó có nhiều loài được ghi vào sách đỏ của Tổ chức Bảo tồn thiên nhiên Quốc tế.Nhờ có môi trường sinh thái ổn định và phù hợp nên các loài chim, cò đều tụ hợp về đây sinh sản, trú ngụ và phát triển với số lượng đông đúc. Đó là những loài như chích cồ, còng cọc, vạc, điên điển, le le, cúm núm, chàng bè, sếu đen… và rất nhiều loài cò như: cò trắng, cò xanh, cò đỏ, cò hương, dơi quạ… trong đó có hàng chục loại chim, thú quý hiếm được ghi vào Sách đỏ của Tổ chức Bảo tồn thiên nhiên quốc tế.',3,'rung-u-minh-ha-ca-mau',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Khu Đa Dạng Sinh Học Lâm Ngư Trường 184', N'Khu bảo tồn đa dạng sinh học Lâm ngư trường 184 nằm giữa khu rừng đước Năm Căn thuộc ấp Chà Là, xã Tam Giang, huyện Năm Căn, tỉnh Cà Mau. Khu bảo tồn có diện tích 252 ha, trong đó bao gồm khu bảo tồn nghiêm ngặt và vùng đệm. Đây là khu rừng mang nét đặc trưng của hệ sinh thái rừng ngập mặn Cà Mau đang được phát triển trở thành khu du lịch sinh thái hàng đầu của miền Tây Nam Bộ.Khu bảo tồn đa dạng sinh học 184 có 44 loài thực vật, trong đó có 32 loài đặc trưng cho hệ sinh thái rừng ngập mặn, chiếm ưu thế là cây đước trên 20 năm tuổi. Đặc biệt có một số loài quý hiếm như cóc trắng, đưng, sú, vẹt; có 6 loài chim, 5 loài thú, 2 loài bò sát, 2 loài lưỡng thê. Hệ động, thực vật được bảo tồn để phục vụ công tác nghiên cứu, tìm hiểu, tham quan, du lịch. Dưới tán rừng, các loài động vật rất phong phú với sự hiện diện của đông đảo của những bầy khỉ, voọc, sóc, chồn, rái cáGiữa khu rừng có một máng chim, có nhiều loài chim về trú ngụ, sinh sản. Trong đó, tiêu biểu nhất là cò và vạc lên đến hàng ngàn cá thể cùng với nhiều loài khác như lắc nước, ốc cao, trích đến những loài chim lớn hơn như giang sen, già đẩy cũng về đây xây tổ. Nơi đây, còn là môi trường thuận lợi cho nhiều loài bò sát như rắn hổ đước, hổ mây, đẻn, kỳ đà… các loài lưỡng thê, giáp xác, nhuyễn thể sinh sôi, phát triểnRừng đước Năm Căn gây ấn tượng với du khách bởi hệ thống dòng sông nhỏ, kênh rạch nhiều như mạng nhện, cây đước vươn cao ngày đêm âm thầm dấn bước chân mình ra biển khơi.',3,'khu-da-dang-sinh-hoc-ngu-lam-truong-184',1,1)
Insert Into TouristAttraction([Name],[Description],[PlaceTypeID],[MetaTitle],[ParentID],[DisplayOrder]) values(N'Rừng Đước Năm Căn Cà Mau', N'Rừng đước Năm Căn hay rừng đước Cà Mau là một khu rừng ngập mặn nổi tiếng ở miền Tây.Cùng với rừng tràm U Minh Hạ, hai khu rừng này đã tạo thành một vỏ bọc kiên cố ngăn cho Cà Mau khỏi sự xâm thực của biển, chống xoáy lở và cân bằng hệ sinh tháiNơi đây chính là căn cứ vững chắc để giúp quân và dân ta làm tan tác bao cuộc càn quét trong hai cuộc hang chiến. Vì thế, có thể nói rừng đước Năm Căn là một yếu tố quan trọng nuôi dưỡng tâm hồn con người và đóng góp đáng kể vào sự phát triển củacả tỉnh Cà Mau và đất nước.Vào mùa khô, du khách sẽ được chứng kiến khung cảnh hoang sơ của lõi rừng nguyên sinh với những cây đước cổ thụ to gần bằng thân người và hàng ngàn những chiếc rễ ngoằn ngoèo xòe rộng ra xung quanh rồi lại đan xen vào nhau, đẹp tựa tranh vẽĐặc biệt, khi đi sâu vào trong rừng, bạn sẽ có cảm giác mình như đang lạc vào một mê cung huyền bí, chỉ cần không tập trung một chút thôi là có thể bị lạc mãi mãi không thoát ra được, cảm giác kích thích này sẽ thu hút rất nhiều người yêu thích mạo hiểm.',3,'rung-nuoc-nam-can-ca-mau',1,1)