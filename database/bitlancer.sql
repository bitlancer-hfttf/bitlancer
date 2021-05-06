-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 06 May 2021, 18:37:46
-- Sunucu sürümü: 10.4.10-MariaDB
-- PHP Sürümü: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `bitlancer`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `items`
--

DROP TABLE IF EXISTS `items`;
CREATE TABLE IF NOT EXISTS `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `items`
--

INSERT INTO `items` (`id`, `item_name`) VALUES
(2, 'Altın'),
(3, 'Gümüş'),
(4, 'TL'),
(5, 'Elmas');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_adds`
--

DROP TABLE IF EXISTS `item_adds`;
CREATE TABLE IF NOT EXISTS `item_adds` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `date` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `state` tinyint(1) NOT NULL,
  `description` text COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_adds`
--

INSERT INTO `item_adds` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`, `date`, `state`, `description`) VALUES
(1, 4, 2, 150, 5, '2021-05-06', 1, 'TAMAMLANDI');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_orders`
--

DROP TABLE IF EXISTS `item_orders`;
CREATE TABLE IF NOT EXISTS `item_orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `destination_user_id` int(11) NOT NULL,
  `source_user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `order_unit_price` double NOT NULL,
  `order_quantity` int(11) NOT NULL,
  `order_type` varchar(2) COLLATE utf8_turkish_ci NOT NULL,
  `order_state` int(11) NOT NULL,
  `order_date` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `destination_user_id` (`destination_user_id`,`source_user_id`,`item_id`),
  KEY `source_user_id` (`source_user_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `item_user_infos`
--

DROP TABLE IF EXISTS `item_user_infos`;
CREATE TABLE IF NOT EXISTS `item_user_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id` (`user_id`,`item_id`),
  KEY `item_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `item_user_infos`
--

INSERT INTO `item_user_infos` (`id`, `user_id`, `item_id`, `quantity`, `unit_price`) VALUES
(1, 3, 2, 90, 5),
(3, 4, 2, 7541, 12.8),
(4, 3, 4, 225254, 1),
(5, 4, 4, 10050, 1),
(6, 3, 3, 1500, 5.8),
(10, 4, 5, 45123, 4.7),
(11, 4, 3, 8421, 5.754245);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_full_name` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_name` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_password` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_address` varchar(1000) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_mail` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `user_type_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_type_id` (`user_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `user_full_name`, `user_name`, `user_password`, `user_address`, `user_mail`, `user_type_id`) VALUES
(3, 'Muhammet Sezer Yıldırım', 'sezer_admin', '123', 'Çanakkale', 'asd@gmail.com', 5),
(4, 'Enes Koyuncu', 'enesk', '123', 'izmir', 'asdas@gmail.com', 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user_type_infos`
--

DROP TABLE IF EXISTS `user_type_infos`;
CREATE TABLE IF NOT EXISTS `user_type_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_type` varchar(64) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `user_type_infos`
--

INSERT INTO `user_type_infos` (`id`, `user_type`) VALUES
(5, 'admin'),
(6, 'basic');

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `item_adds`
--
ALTER TABLE `item_adds`
  ADD CONSTRAINT `item_adds_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`),
  ADD CONSTRAINT `item_adds_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Tablo kısıtlamaları `item_orders`
--
ALTER TABLE `item_orders`
  ADD CONSTRAINT `item_orders_ibfk_1` FOREIGN KEY (`destination_user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_orders_ibfk_2` FOREIGN KEY (`source_user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_orders_ibfk_3` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`);

--
-- Tablo kısıtlamaları `item_user_infos`
--
ALTER TABLE `item_user_infos`
  ADD CONSTRAINT `item_user_infos_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `item_user_infos_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `items` (`id`);

--
-- Tablo kısıtlamaları `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`user_type_id`) REFERENCES `user_type_infos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
