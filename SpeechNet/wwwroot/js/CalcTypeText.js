window.onload = () => {
    $(".btn-success").click(() =>
    {
        // исходное слово
        let txt = $("#text-input").val();

        // часть речи по мнению юзера
        let partSpesh = $("#part-input").val();

        // часть речи по мнению логики
        //txt = txt.toLowerCase(); // переводит слова в мелкие буквы иначе код робит не корктно. Да, хуита, поэтому здесь этот комент)
        if (txt !== undefined || txt !== "") {
            $.ajax({
                url: "/Text",
                type: "POST",
                data: { text: txt },
                dataType: 'JSON',
                contentType: 'application/x-www-form-urlencoded',
                success: function (responce) {

                    $("#result").text(responce);

                },
                error: function (responce) {
                    statusText = "Пустое окно!";
                    alert( `${responce.statusText} StatusCode: ${responce.status}`)
                }
            });
            $("a").click(() => { $("a").removeClass("active") });
        }
    });
};
