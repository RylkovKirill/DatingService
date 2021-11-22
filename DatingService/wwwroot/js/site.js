$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

function changeMenu() {
    const sidebar = document.getElementById("sidebar");
    sidebar.classList.toggle("active");
}