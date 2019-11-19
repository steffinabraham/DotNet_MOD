import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Mentor } from 'src/app/models/mentor/mentor';
import { MentorService } from 'src/app/service/mentor/mentor.service';

@Component({
  selector: 'app-mentorsignup',
  templateUrl: './mentorsignup.component.html',
  styleUrls: ['./mentorsignup.component.css']
})
// export class MentorsignupComponent implements OnInit {
//   mentor_name;
//   email_id;
//   pass_word;
//   message='';
//   status;
  

//   constructor(private http: HttpClient) { }

//   ngOnInit() {
//   }

//   submit_form_data(){
//     console.log("mentor_name : " + this.mentor_name);
//     console.log("email_id : " + this.email_id);
//     console.log("pass_word : " + this.pass_word);

//     var body = "mentor_name=" + this.mentor_name 
//         + "&email_id=" + this.email_id 
//         + "&pass_word=" + this.pass_word
//         + "&status=" + "active";
	
//     let headers = new HttpHeaders({'Content-Type': 'application/x-www-form-urlencoded'});

//     this.http.post("http://localhost:3000/mentor/", body, 
//                   {headers: headers, responseType:'text'}).subscribe(
//       (result) => {
//         console.log(result)
//         this.message = "Congratulations, You had successfully registered"
//       },
//       (error) => {
//         console.log(error)
//         this.message = "Error : Backend is running? or Registered already?";
//       }
//     )
//   }

// }





export class MentorsignupComponent implements OnInit {
  item:Mentor;
  list:Mentor[];
  msg:string;

  constructor(private _service:MentorService) {
    this.item=new Mentor();
    this._service.GetAll().subscribe(k=>this.list=k)
   }

  ngOnInit() {
  }
public Add(){
  this._service.Add(this.item).subscribe(k=>this.msg=k)
}
}
