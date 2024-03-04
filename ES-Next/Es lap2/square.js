import{ rectangle }from'./rectangle.js'
export class square extends rectangle{
    constructor(_width){
        super(_width,_width);
    }
    calcArea(){
        return super.calcArea();
    }
}