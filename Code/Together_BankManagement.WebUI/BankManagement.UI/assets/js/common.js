function openPopupModal(url) {
    $('iframe').attr("src", url);

    $("#myModal").modal({ show: true });

    return false;
};

parent.closePopupModal = function () {
    $("#myModal").modal('hide');
    return false;
}

parent.reloadPage = function () {
    location.reload();
    return false;
}

parent.fitIframeSize = function () {
    var elementHeight = $("#frameContainer1").contents().find("#container-modal").height() + 10;
    $("#frameContainer1").css("height", elementHeight + "px");
}

parent.setModalTitle = function () {
    var title = $("#frameContainer1").contents().find("title").text();
    $("#myModal .modal-title").text(title);
}