let mainBranchButton=document.querySelector(".main-branch-span")
let normalBranchButton=document.querySelector(".normal-branch-span")
let smartContainer=document.querySelector(".smart-container")
let normalBranch=document.querySelectorAll(".normal-branch")

let mainBranchCheckBox = document.querySelector('.main-branch-span i.fa-solid');
let normalBranchCheckBox = document.querySelector(".normal-branch-span i.fa-solid");

mainBranchButton.addEventListener("click",function(){
    normalBranch.forEach(branch=>branch.style.color="lightgray")
    smartContainer.style.color="black"
    mainBranchCheckBox.classList.add('brown');
    normalBranchCheckBox.classList.remove('brown');
})
normalBranchButton.addEventListener("click",function(){
    smartContainer.style.color="lightgray"
    normalBranch.forEach(branch=>branch.style.color="black")
    normalBranchCheckBox.classList.add('brown');
    mainBranchCheckBox.classList.remove('brown');
})