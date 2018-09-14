$(document).ready(function() {
  $("#create-string").click(function() {
    var newString = $("#new-string").val();
    if (newString == "") {
      alert("you must enter something")
      event.preventDefault();
    }
  });
  $("#create-word").click(function() {
    var newWord = $("#new-word").val();
    if (newWord == "") {
      alert("you must enter something")
      event.preventDefault();
    }
  });
});
