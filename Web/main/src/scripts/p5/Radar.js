let p5;
let bubble;
export function main(p5Init){
  p5 = p5Init; 
  
  // NOTE: Set up is here   
  p5.setup = () => {      
    var canvas = p5.createCanvas(500, 500);
    canvas.parent("p5Canvas");
    bubble =  new Bubble();
  }     
  // NOTE: Draw is here
  p5.draw = () => {      
    p5.background(0);
    p5.push();
    bubble.display();
    p5.pop();
  } 

  p5.mouseClicked = () => {
    bubble = new Bubble();
  }
}

class Bubble {
  constructor(){
    this.x = p5.random(p5.width);
    this.y = p5.random(p5.height);
    this.diameter = 50;
  }

  display(){
    p5.ellipse(this.x, this.y, this.diameter, this.diameter);    
  }
}