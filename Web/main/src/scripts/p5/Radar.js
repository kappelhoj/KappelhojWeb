let p5;
export function main(p5Init){
  p5 = p5Init; 
  const defaultSpeed = 2;
  var speed = defaultSpeed;    
  var posX = 0;
  
  // NOTE: Set up is here   
  p5.setup = () => {      
    var canvas = p5.createCanvas(500, 500);
    canvas.parent("p5Canvas");    
    p5.ellipse(p5.width / 2, p5.height / 2, 500, 500);    
  }     
  // NOTE: Draw is here
  p5.draw = () => {      
    p5.background(0);
    const degree = p5.frameCount * 3;      
    const y = p5.sin(p5.radians(degree)) * 50;
    
    p5.push();
    p5.translate(0, p5.height / 2);
    p5.ellipse(posX, y, 50, 50);
    p5.pop();
    posX += speed;
      
    if (posX > p5.width) {    
      speed = -defaultSpeed;      
    }
    else if(posX < 0){
      speed = defaultSpeed;
    }
  } 

  p5.mouseClicked = () => {
    speed = reverse_speed(speed);
  }
}

function reverse_speed(speed){
  return speed*-1;
}