<template>
  <div class="nav-item">
    <h3>
      <a :href=path>{{title}}</a>
    </h3>
  </div>
</template>


<script>
export default{
  name: 'NavItem',
  props:{
    title:{
      type: String,
      required: true
    },
    path:{
      type: String,
      required: true
    }
  }
}
</script>


<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .nav-item{
    margin-left: 20px;
  }
  
  a{
    text-decoration: none;
    color: #556b82;
  }
  a:hover{
    color: #2c3e50;
  }
</style>