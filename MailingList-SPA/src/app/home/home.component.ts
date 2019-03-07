import { Component, OnInit } from '@angular/core';
import { RegisterService } from '../_services/register.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  userDetails: any = {};

  constructor(private registerService: RegisterService) { }

  signUp() {
    this.registerService.signUp(this.userDetails).subscribe(
      x => console.log(`Success! ${x} was subscribed!`),
      err => console.log(`Error occured: ${err}`)
    );
  }

  ngOnInit() {
  }

}
