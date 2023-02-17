// Size bir soz gelir. hemin sozde hansi herfden  nece dene oldugunu tapan alqoritm yazin
"use strict";
CalculateLetters("nicat novruzzade");
function CalculateLetters(word) {
  for (let i = 0; i < word.length; i++) {
    let n = 0;
    for (let j = 0; j < word.length; j++) {
      if (word[i] == word[j]) {
        if (i > j) {
          break;
        }
        n++;
      }
    }
    if (n > 0) {
      if (word[i] != " ") {
        console.log(`${word[i]} herfi ${n} defe`);
      } else {
        i++;
      }
    }
  }
}
