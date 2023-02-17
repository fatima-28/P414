// //  Promtdan size bir ad ve yash gelir.
// adin icinde herhansisa bir reqem varsa size bildirish cixarsin ki "Adda reqem ola bilmez.",
// eger duzgundurse onda sizden yasi istesin. yasda herf varsa desin ki"format duzgun deil".
// Yas 18den kicikdirse desin ki "Size sehifeye girmek olmaz". En sonda consolede adi ve
//  yashi gorebilek.
// Kodu seliqeli sehilde funskiyalara cixararaq yazin

"use strict";

let name = prompt("Enter name: ");

if (checkName(name)) {
  let age = prompt("Enter age: ");
  checkAge(age);
} else {
  alert("ad duzgun deyil!");
}

function checkAge(age) {
  if (!isNaN(age)) {
    if (!IsBiggerThanEighteen(age)) {
      alert("size sehifeye girmek olmaz");
    } else {
      console.log("Name: " + name + " Age: " + age);
    }
  } else {
    alert("yasda herf ola bilmez");
  }
}

function IsBiggerThanEighteen(age) {
 if (age<18) {
    return false;
 }
 else{
   return true;
 }
}
function checkName(name) {
  if (!containsNumber(name)) {
    return true;
  } else {
    return false;
  }
}

function containsNumber(str) {
  return Boolean(str.match(/\d/));
}
