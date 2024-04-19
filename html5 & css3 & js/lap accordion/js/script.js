window.addEventListener('load', function () {
    let students = [
        {id: 1, name: 'dina', img: '2.jpg'},
        {id: 2, name: 'salma', img: '5.jpg'},
        {id: 3, name: 'merna', img: '4.jpg'}
    ];

    students.forEach(function (student, index) {
        document.getElementById('span' + (index + 1)).innerText = student.name;
        document.getElementById('id' + (index + 1)).innerText = student.id;
        document.getElementById('img' + (index + 1)).src = student.img;

    });
});
