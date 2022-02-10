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
    bubble.draw();
    p5.pop();
  } 

  p5.touchEnded = () => {
    if(bubble.contains(p5.mouseX, p5.mouseY)){
      bubble = new Bubble();
    }
  }
}

class Bubble {
  constructor(){
    this.diameter = 50;
    this.x = p5.random(this.diameter, p5.width-this.diameter);
    this.y = p5.random(this.diameter, p5.height-this.diameter);
  }

  contains(pX, pY){
    let d = p5.dist(pX, pY, this.x, this.y);

    return d < (this.diameter / 2)
  }

  draw(){
    p5.ellipse(this.x, this.y, this.diameter, this.diameter);    
  }
}