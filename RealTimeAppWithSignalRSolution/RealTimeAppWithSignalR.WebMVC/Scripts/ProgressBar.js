$(function () {
    var hub = $.connection.progressBar;
    hub.client.update = function (value) {
        $("#progressBar").css("width", value + "%")
            .text(value + " %");
    };
    $("#start").click(function () {
        $(this).attr("disabled", true);
        $("#result")
            .hide("slow")
            .load("/ProgressoDeProcessamento/StartProcess?connectionId=" + $.connection.hub.id,
            function () {
                
                AvisaFimDeProcessamento();
                $("#start").attr("disabled", false);
            });
    });
    $.connection.hub.start()
        .done(function () {
            $("#start").attr("disabled", false);
        });
});

function AvisaFimDeProcessamento() {
    alert("Seu processamento foi concluído.")
}