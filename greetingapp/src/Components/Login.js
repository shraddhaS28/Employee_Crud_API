import React from 'react';
import { Component } from 'react';

export default class Login extends Component {
    constructor(props) {
        super(props)
        this.state = {
            email: "",
            password: ""
        }
    }
    handleEmailChange=(event)=>{
        const email=event.target.value;
        this.setState({
            email:email
        })
        console.log("email",this.state.email)
    }
    handlePasswordChange=(event)=>{
        const email=event.target.value;
        this.setState({
            password:email
        })
        console.log("password",this.state.password)
    }
    handleSubmitButton=()=>{
        var data= {
            Email: this.state.email,
            Password: this.state.password
        }
        console.log("data",data);
        console.log("status",this.state.email, this.state.password);
    }
    render() {
        return (
            <div className="main-div">
                <div className="login-div">Login</div>
                <div className="main-Test-div">
                    
                    <div className="email-div">
                        <input type="email" className="input-email-div" placeholder="Email" onChange={this.handleEmailChange}/>
                    </div>
                    <div className="email-div">
                        <input type="password" className="input-email-div" placeholder="Password" onChange={this.handlePasswordChange} />
                    </div>
                
                </div>
                <div className="app-button">
                    <button className="submit" onClick={this.handleSubmitButton}>Submit</button>
                </div>
            
            </div>

        )


    }

}