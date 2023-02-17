// "use strict";

// // Userleriniz var ve bu userler bir arrayin icinde toplanib.
// // ageDedector functionunz array ve callback qebul edir.Eger userin yasi 18den asagidirsa
// // Bu adli userin yasi catmir consola cixsin. Eger yasi catirsa callbacden istifade ederek basqa bir
// // regsiter functionunuz islesin ve consola ad ve yas succesfuly registered cixarilsin

// let user1 = {
//   name: "Nicat",
//   age: 15,
// };

// let user2 = {
//   name: "Fatime",
//   age: 20,
// };

// let user3 = {
//   name: "Murad",
//   age: 19,
// };

// let users = [user1, user2, user3];


// function ageChecker(age) {
//   return age < 18;
// }

// function register(user) {
//   return `name: ${user.name}\nage: ${user.age}\nSuccesfully registered`;
// }

// function userDetector(arr, callback1, callback2) {
//   for (const user of arr) {
//     if (callback1(user.age)) {
//       console.log(`${user.name}-in yashi chatmir.`);
//     } else {
//       console.log(callback2(user));
//     }
//   }
// }

// userDetector(users, ageChecker, register);
