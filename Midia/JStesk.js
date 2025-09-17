var canvas = document.getElementById('myCanvas'),
    context = canvas.getContext('2d');


function onMouseDown(e){
    console.log("Mouse Down",e);
    //clear the canvas
    context.clearRect(0, 0, canvas.width, canvas.height); 
    context.strokeText("Hello", e.clientX,  e.clientY);
}

function onKeyDown(e){
    console.log("Key Down", e);

    context.clearRect(0,0,canvas.width.canvas.height);
    context.strokeText("The end",canvas.width/2,canvas.hight/2); 
}

function init(){

    context.fillStyle='green';
    context.lineWidth=3;
    context.textAlign='center';
    context.textBaseline='middle';
    
    context.font="80pt Garamond";
    
    context.fillText("Click to Start", canvas.width/2,  canvas.height/2);
    context.strokeText("Click to Start", canvas.width/2,  canvas.height/2);

    //召唤hello
    canvas.addEventListener('mousedown', onMouseDown);

    canvas.addEventListener ('keydown', onKeyDown);
}

init();