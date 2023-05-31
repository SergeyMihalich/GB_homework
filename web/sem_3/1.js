let inp = Number.parseFloat(prompt('Введи температуру (цельсия): '));
alert(`Цельсий: ${inp}\nФаренгейт: ${((9 / 5) * inp + 32).toFixed(3)}`)