//parameters will specify date you put to input
// var date = new Date(year, month, day, hours, minutes, seconds, milliseconds);

// show current month
const months = [
   "January",
   "February",
   "March",
   "April",
   "May",
   "June",
   "July",
   "August",
   "September",
   "October",
   "November",
   "December",
];
let currentMonth = months[new Date().getMonth()];
console.log(currentMonth);

const currentDate = new Date().getDate();
console.log(currentDate);

// show current day
const localDate = new Date();
const days = [
   "Sunday",
   "Monday ",
   "Tuesday",
   "Wednesday",
   "Thursday",
   "Friday",
   "Saturday",
];

const currentDay = days[new Date().getDay()];
console.log(currentDay);
