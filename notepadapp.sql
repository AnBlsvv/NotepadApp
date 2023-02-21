-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 04 2022 г., 07:16
-- Версия сервера: 10.4.24-MariaDB
-- Версия PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `notepadapp`
--

-- --------------------------------------------------------

--
-- Структура таблицы `text_information`
--

CREATE TABLE `text_information` (
  `ID` int(11) NOT NULL,
  `Date` timestamp NOT NULL DEFAULT current_timestamp(),
  `Label` text NOT NULL,
  `Label_Info` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `text_information`
--

INSERT INTO `text_information` (`ID`, `Date`, `Label`, `Label_Info`) VALUES
(1, '2022-05-04 05:15:18', 'Text1', 'Pellentesque eget sollicitudin felis, vitae pulvinar dolor. Praesent laoreet in velit ac ultrices. Mauris vitae fringilla massa. Aliquam gravida nisl dolor, ac blandit urna tincidunt a. Cras luctus consequat velit eu tincidunt. In elementum scelerisque magna. Integer mattis consectetur est, id rhoncus nunc auctor quis. Cras quis iaculis est, ut ultricies mi. Maecenas lobortis, elit non consequat fringilla, purus nisl tincidunt magna, at maximus libero ante eget odio. Proin sit amet viverra nisl, sed auctor risus. Donec vel magna mi. Nulla iaculis gravida augue, quis euismod quam consequat et.'),
(2, '2022-05-04 05:15:32', 'text2', 'Etiam pretium orci augue, a porttitor elit condimentum in. Donec vulputate metus sed quam eleifend maximus. Praesent sit amet vestibulum purus, non consequat justo. Nulla consequat odio turpis, id lobortis risus commodo a. Integer id risus nibh. Cras efficitur porta libero. Morbi sed quam fermentum elit dignissim efficitur non ac felis. Maecenas eget pretium lacus. Aliquam erat volutpat. Sed posuere mauris felis, sit amet malesuada orci tempus et. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer quam lacus, tempor nec nibh ut, maximus feugiat felis.'),
(3, '2022-05-04 05:15:49', 'текст3', 'Значимость этих проблем настолько очевидна, что постоянный количественный рост и сфера нашей активности способствует подготовки и реализации существенных финансовых и административных условий. Таким образом постоянное информационно-пропагандистское обеспечение нашей деятельности способствует подготовки и реализации новых предложений. Товарищи! рамки и место обучения кадров позволяет выполнять важные задания по разработке модели развития. С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности обеспечивает широкому кругу (специалистов) участие в формировании соответствующий условий активизации.');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `text_information`
--
ALTER TABLE `text_information`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `text_information`
--
ALTER TABLE `text_information`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
