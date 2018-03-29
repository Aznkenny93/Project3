// JavaScript Document

$(document).ready(function(){
	$("#OV").on("click", function() {
		if ($(this).is(":checked")) {
			$(".auto_next").css({"display": "none"})
			//$(".ov_next").css({"display": "block"})
			$(".ov_next").fadeIn()
			//$(".Vraag_2").css({"display": "block"})
			//$(".Vraag_2").fadeIn()
		}
	});
	
	$("#Auto").on("click", function() {
		if ($(this).is(":checked")) {
			$(".ov_next").css({"display": "none"})
			//$(".auto_next").css({"display": "block"})
			$(".auto_next").fadeIn()
			//$(".Vraag_2").css({"display": "block"})
			//$(".Vraag_2").fadeIn()
		}
	});
});