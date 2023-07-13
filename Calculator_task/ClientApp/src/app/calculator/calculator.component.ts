import { Component, OnInit} from '@angular/core';
import { UserViewModel } from '../models/UserVewModel';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  constructor(private userService: UserService) {}

  favColour: string = "Black";
  fcolours: string[] = ["Red", "Yellow", "Blue", "Black"];

  user: UserViewModel;

    ngOnInit() {
      this.user = new UserViewModel();
      this.user.result = "";
      this.user.error = "";
    }


  getColurStyles() {
    return this.favColour;
  }


  add() {

    this.user.result = "";
    this.user.error = "";

    this.user.firstNum = +this.user.firstNumber;
    this.user.secondNum = +this.user.secondNumber;

    //check if numbers
    if (!Number.isFinite(this.user.firstNum)) {
      this.user.error = "First Number is not a number";
      return false;
    }

    if (!Number.isFinite(this.user.secondNum)) {
      this.user.error = "Second Number is not a number";
      return false;
    }

    if (this.user.firstNumber && this.user.secondNumber) {

      //get the calculation
      this.userService.add(this.user).subscribe(result => {
        this.user.result = result.toString();
        },
          error => {
            this.user.error = "There has been an error getting the calculation";
          }
        );

    }
    else {
      this.user.error = "Please enter a first and Second Number";
    }


  }



  minus() {

    this.user.firstNum = +this.user.firstNumber;
    this.user.secondNum = +this.user.secondNumber;

    //check if numbers
    if (!Number.isFinite(this.user.firstNum)) {
      this.user.error = "First Number is not a number";
      return false;
    }

    if (!Number.isFinite(this.user.secondNum)) {
      this.user.error = "Second Number is not a number";
      return false;
    }


    if (this.user.firstNum && this.user.secondNum) {

      this.user.result = "";
      this.user.error = "";

      //get the calculation
      this.userService.minus(this.user).subscribe(result => {
        this.user.result = result.toString();
      },
        error => {
          this.user.error = "There has been an error getting the calculation";
        }
      );
 
    }
    else {
      this.user.error = "Please enter a first and Second Number";
    }


  }


  

    


}
