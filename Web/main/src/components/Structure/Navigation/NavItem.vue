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
    color: var(--secondary-dark-color);
  }
  a:hover{
    color: var(--main-text-color);
  }
</style>