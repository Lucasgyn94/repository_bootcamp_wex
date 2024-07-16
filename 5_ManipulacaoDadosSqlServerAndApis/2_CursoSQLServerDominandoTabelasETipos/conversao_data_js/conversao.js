const fs = require('fs');

// Função para converter o formato de data para o formato do SQL Server
function convertDateToSQLFormat(dateString) {
  const months = {
    'Jan': '01', 'Feb': '02', 'Mar': '03', 'Apr': '04', 'May': '05', 'Jun': '06',
    'Jul': '07', 'Aug': '08', 'Sep': '09', 'Oct': '10', 'Nov': '11', 'Dec': '12'
  };

  const parts = dateString.match(/(\w{3})\s+(\d{1,2})\s+(\d{4})\s+(\d{1,2}:\d{2}(AM|PM))/);

  if (parts) {
    const [, month, day, year, time] = parts;
    const monthNumber = months[month];
    const sqlFormattedDate = `${year}-${monthNumber}-${day} ${time}`;
    return sqlFormattedDate;
  }

  return dateString; // Retorna a data original se o formato não for correspondido
}

// Função para processar o arquivo de texto
function processTextFile(fileName) {
  const outputFile = 'output.sql'; // Nome do arquivo de saída
  const lines = fs.readFileSync(fileName, 'utf8').split('\n');

  const sqlStatementsWithFormattedDates = lines.map(line => {
    const parts = line.split("',"); // Divide a linha em partes
    if (parts.length === 5) {
      parts[4] = convertDateToSQLFormat(parts[4]); // Converte a data
    }
    return parts.join("',"); // Reconstroi a linha com a data formatada
  });

  fs.writeFileSync(outputFile, sqlStatementsWithFormattedDates.join('\n'), 'utf8');
}

// Chame a função para processar o arquivo de texto
const inputFileName = './dados.txt'; // Substitua com o nome do seu arquivo de texto
processTextFile(inputFileName);
