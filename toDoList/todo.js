// $(this).css("color","gray");
// $(this).css("textDecoration","line-through");

// $("li").click(function(){
   // $(this).toggleClass("completed");
// })
$("ul").on("click","li",(function(){
   $(this).toggleClass("completed");
})
)
$("ul").on("click","span",(function(event){
	$(this).parent().fadeOut(500,function(){
		$(this).remove();
	});
	event.stopPropagation();
})
)
$("input[type='text'").keypress(function(event){
	if(event.which === 13){
		var todotask = $(this).val();
		$(this).val("");
	$("ul").append("<li><span><i class='fas fa-trash-alt'></i> </span>"+ todotask +"</li>");
	}
});
$(".fa-clipboard-list").click(function(){
  $("input[type='text'").fadeToggle();
});