import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../_services/register.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  userDetails: any = {};
  error = false;
  errorMsg: string;
  success = false;

  constructor(private registerService: RegisterService) { }

  signUp() {
    this.success = false;
    this.error = false;
    this.registerService.signUp(this.userDetails).subscribe(
      x => this.success = true,
      err => this.errorMethod(err),
    );
  }

  errorMethod(error: string){
    console.log(error);
    this.errorMsg = error;
    this.error = true;
  }

  ngOnInit() {
  }

}
