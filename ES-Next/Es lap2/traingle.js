import { shape } from "./shape.js";
export class traingle extends shape{
    #h1 =0;
    #h2 =0;
    constructor(_h1,_h2){
        super();
        this.x = _h1;
        this.y = _h2;
    }
    set H1(_h1){
        this.#h1 = _h1
    }
    get H1(){
        return this.#h1;
    }
    set H2(_h2){
        this.#h1 = _h2
    }
    get H2(){
        return this.#h2;
    }
    calcArea(){
        return 0.5 * this.H1 * this.H2;
    }
    
}