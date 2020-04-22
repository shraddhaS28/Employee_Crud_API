import React from 'react';
import {Component} from 'react';

class Formula extends Component {
render(){
   return (
       
       <div>
       <label  id='formula-label'>Formula:</label>
       {
           (this.props.selectTypeLeft==="Feet" && this.props.selectTypeRight==="Inch") ?
           <i> Multiply the Feet value by 12.</i> : 
           (this.props.selectTypeLeft==="Inch" && this.props.selectTypeRight==="Feet") ?
           <i> Divide the Inch value by 12.</i> :
           (this.props.selectTypeLeft==="Meter" && this.props.selectTypeRight==="Centimeter") ? 
           <i> Multiply the Meter value by 100.</i> :
           (this.props.selectTypeLeft==="Centimeter" && this.props.selectTypeRight==="Meter") ?
           <i> Divide the Centimeter value by 100.</i> :
           (this.props.selectTypeLeft==="Kilogram" && this.props.selectTypeRight==="Gram") ?
           <i> Multiply the Kilogram value by 1000.</i> :
           (this.props.selectTypeLeft==="Gram" && this.props.selectTypeRight==="Kilogram") ?
           <i> Divide the Gram value by 1000.</i> : null
       }
   </div>
)
}
}
export default Formula;