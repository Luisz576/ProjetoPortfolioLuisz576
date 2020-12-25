DROP DATABASE IF EXISTS Luisz576;

CREATE DATABASE Luisz576;

USE Luisz576;

CREATE TABLE IF NOT EXISTS Admins(
	login varchar(20) NOT NULL PRIMARY KEY,
    senha varchar(20) NOT NULL
);

CREATE TABLE IF NOT EXISTS projetos(
	id int PRIMARY KEY NOT NULL AUTO_INCREMENT,
    nome varchar(30) NOT NULL,
    descricao text NOT NULL,
    imagem text NOT NULL,
    alternativo text NOT NULL,
    url text NOT NULL
);

CREATE TABLE IF NOT EXISTS curriculo(
	id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	titulo varchar(30) NOT NULL,
    texto text NOT NULL
);

CREATE TABLE IF NOT EXISTS orcamento(
	id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	lido bool NOT NULL default false,
    nome varchar(30) NOT NULL,
    telefone varchar(15) NOT NULL,
    email varchar(50) NOT NULL,
    descricao text NOT NULL,
    ios bool NOT NULL default false,
    android bool NOT NULL default false,
    web bool NOT NULL default false
);

CREATE TABLE IF NOT EXISTS blog(
	id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	title varchar(35) NOT NULL,
	content text NOT NULL
);

/*INSERTs*/
INSERT INTO Admins (login, senha) VALUES ('adm', 'adm');

INSERT INTO curriculo (id, titulo, texto) VALUES
(7, 'Flutter(Android & iOS)', 'Flutter é um open-source feito em Dart, permite compilar um mesmo código, tanto para Android, quanto iOS. Aplicações feitas com Flutter apresentam um ótimo desempenho, além é claro, de um ótimo designer.'),
(8, 'Web(HTML5, JavaScript...)', 'Com a utilização do HTML, CSS e Javascript puro, dependendo do projeto, adiciona-se Jquery, dentre outros frameworks para melhorar os resultados de seu site.'),
(9, 'Web(ASP.NET Core MVC)', 'Atualmente, em 2020, estou estudando o ASP.NET Core MVC, para desenvolvimento de sites. O ASP.NET Core MVC é uma estrutura avançada para a criação de aplicativos Web e APIs usando o padrão de design Model-View-Controller.');

INSERT INTO projetos (id, nome, descricao, imagem, alternativo, url) VALUES
(1, '1°Jogo multiplayer online', 'Um jogo bem simples feito para web utilizando javascript e node.js para rodar.', 'game_print.png', 'Imagem do projeto', 'https://github.com/Luisz576/gameOnline'),
(2, 'MyRPG', 'Um suporte de RPG, super util em partidas com amigos!', 'rpg.png', 'Imagem do projeto', 'https://github.com/Luisz576/MyRpg-support'),
(3, '1°Jogo multiplayer online', 'Um jogo bem simples feito para web utilizando javascript e node.js para rodar.', 'game_print.png', 'Imagem do projeto', 'https://github.com/Luisz576/gameOnline'),
(4, '1°Jogo multiplayer online', 'Um jogo bem simples feito para web utilizando javascript e node.js para rodar.', 'game_print.png', 'Imagem do projeto', 'https://github.com/Luisz576/gameOnline');

INSERT INTO blog (title, content) VALUES
('Luisz576 - Post', '<p><b>Esse é o <u>primeiro</u> post do site!</b></p>\r\n<p>Seja muito bem vindo(a)!</p>\r\n<p>Aqui postarei algumas coisas sobre tecnologias, eventos, entre outros</p>\r\n<h4><ul>Esse é apenas o começo!!!</u></h4>\r\n<img src=\"https://miro.medium.com/max/700/1*8g-r3S137F-0eShJVUGmOw.jpeg\" style=\"width: 100%\">'),
('Tinbot sofreu robofobia!', '<p>Galera, saca só esse vídeo do Tinbot, é mt massa esse <u><i>robozinho</i></u>.</p>\r\n<br>\r\n<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/4cd44Cg2oK8\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>'),
('The last of Us 2 - O começo (Alan)', '<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/c2o2r2YuxQo\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\nVídeo de Alanzoka <a href=\"https://www.youtube.com/user/ElectronicDesireGE\">>Canal do youtube<</a>'),
('Meu canal do YOUTUBE', '<p>Salve galera blz?</p>\r\n<p>Não se esqueçam de se inscreverem no meu <a href=\"https://www.youtube.com/channel/UCI_NylhJdIz10I8uIrhfWSw\">canal do youtube</a>!</p>\r\n<p>Fiquem com um de meus vídeos mais recente atualmente:</p>\r\n<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/Omlj05PmqE0\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n<p>E tb não se esqueçam de me seguirem no instagram <a href=\"https://www.instagram.com/Luisz576/\">>@Luisz576<</a>');