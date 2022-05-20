-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Maio-2022 às 00:12
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `petvet`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal`
--

CREATE TABLE `animal` (
  `idPet` int(11) NOT NULL,
  `nomeAnimal` varchar(50) DEFAULT NULL,
  `idadeAnimal` int(11) DEFAULT NULL,
  `tipoAnimal` varchar(30) DEFAULT NULL,
  `id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `animal`
--

INSERT INTO `animal` (`idPet`, `nomeAnimal`, `idadeAnimal`, `tipoAnimal`, `id`) VALUES
(2, 'Fanfarrão', 6, 'cachorro', NULL),
(3, 'Fanfarrão', 6, 'cachorro', NULL),
(4, 'Fanfarrão', 6, 'cachorro', NULL),
(5, 'Fanfarrão', 6, 'cachorro', NULL),
(6, 'pirleib', 6, 'cachorro', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `dataNascimento` date DEFAULT NULL,
  `login` varchar(50) DEFAULT NULL,
  `senha` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome`, `dataNascimento`, `login`, `senha`) VALUES
(1, 'Gabriel alves de oliveira', '1199-05-18', 'ggg', '1234'),
(3, 'gabriel', '1997-05-18', 'ggggg', '1234'),
(4, 'Gabriel alves de oliveira', '1997-05-18', 'ggg', '1234'),
(5, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '12355'),
(6, 'Gabriel alves de oliveira', '1997-05-18', 'ggg', '1234'),
(7, 'Gabriel alves de oliveira', '1977-05-18', 'gggg', '1234'),
(8, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(9, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(10, 'Gabriel alves de oliveira', '1997-05-18', 'ggg', '1234'),
(11, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1237'),
(12, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(13, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(14, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(15, 'Gabriel alves de oliveira', '1997-05-18', 'gggg', '1234'),
(16, 'Gabriel alves de oliveira', '1997-05-18', 'ggg', '1234'),
(17, 'Gabriel alves de oliveira', '1977-05-18', 'gggggggggggggg', '1234'),
(18, 'Gabriel alves de oliveira', '1997-05-18', 'ggggggg', '123455'),
(19, 'Gabriel', '1997-05-18', 'gbl', '1234');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `animal`
--
ALTER TABLE `animal`
  ADD PRIMARY KEY (`idPet`),
  ADD KEY `id` (`id`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `animal`
--
ALTER TABLE `animal`
  MODIFY `idPet` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `animal`
--
ALTER TABLE `animal`
  ADD CONSTRAINT `animal_ibfk_1` FOREIGN KEY (`id`) REFERENCES `cliente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
