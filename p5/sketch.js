function setup() {
  createCanvas(400, 400);
}

function draw() {
  background("blue");

  // Draw the roof
  fill("red");
  triangle(200, 100, 100, 200, 300, 200);

  // Draw the house
  fill("gray");
  rect(100, 200, 200, 200);

  // Tester la possibilité de faire des ellipses en maintenant la souris enfoncé
  if (mouseIsPressed) {
    // Draw the door
    fill("brown");
    rect(180, 300, 40, 100);
  }
}
